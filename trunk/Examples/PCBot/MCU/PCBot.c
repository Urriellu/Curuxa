/*==================================================================
* Two-wheeled robot controlled from a computer
*
* CMSP-MAX MB_TX to MBP40 TX/CK (pin 25)
* CMSP-MAX MB_RX to MBP40 RX/DT (pin 26)
* See other pinouts below
*
* Adrian Bulnes, aka Urriellu
* http://community.curuxa.org
*=================================================================*/
 
#include <MBP40.h> 

// list of control codes. This is the first byte transmitted through the serial port and indicates the operation being done
//#define CcRESERVED 0
#define CcAuthID 1
#define CcSetLight 10
#define CcSetBaseMovement 11
#define CcStatusLight 100
#define CcStatusBaseMovement 101
#define CcStatusBumper 102
//#define CcRESERVED 255

// Codes used by individual operations:

// CcAuthID - Identification
#define CccAuthID 13

// CcSetLight, CcStatusLight - Receive/send status of a light
#define CccLightFrontLeftOn 50
#define CccLightFrontLeftOff 51
#define CccLightFrontRightOn 52
#define CccLightFrontRightOff 53

// CcSetBaseMovement, CcStatusBaseMovement - Receive/send status of base movement
#define CccBaseMvFwd 20
#define CccBaseMvStop 21
#define CccBaseMvBck 22
#define CccBaseTurnL 23
#define CccBaseTurnR 24
#define CccBaseRotateL 25
#define CccBaseRotateR 26

// CcStatusBumper - Send status of a bumper
#define CccBumperFrontLeftPressed 70
#define CccBumperFrontLeftReleased 71
#define CccBumperFrontRightPressed 72
#define CccBumperFrontRightReleased 73

//========================================================

void ProcessSensors();
void WriteSP(unsigned int8);

#define OSC_8MHz
#include <Delays.h>

// Lights
#define LightFrontLeft RD0
#define LightFrontRight RD1
#define TestLed1 RD2
#define TestLed2 RD3
#define TestLed3 RD4
#define TestLed4 RA4
#define ON 1
#define OFF 0

// Bumpers
#define BumperFrontLeft RB2
#define BumperFrontRight RB1
#define Pressed 0
#define Released 1

// Base movement
#define M1Enable RE0
#define M1In1 RE1
#define M1In2 RE2
#define M2Enable RD7
#define M2In1 RD6
#define M2In2 RD5
#include <L293.h>
#include "BaseMovement.h"

#include "SerialPort.h"
#include "Communication.h"

ConfigBits1(_CP_OFF & _DEBUG_OFF & _FCMEN_OFF  & _IESO_OFF & _CPD_OFF & _LVP_OFF & _BOR_OFF & _MCLRE_OFF & _PWRTE_ON & _WDT_OFF & _INTOSCIO);

void Setup(){
	SetIntosc8MHz();
	AdcDisable();

	//setup UART
	//Baud rate timer: SPBRG=((Fosc/(16 * 9600) -1))
	//Baud rate = Fosc/(16*(SPBRG+1))
	//real resulting baud rate for Fosc=8MHz: 9615.384615 bauds
	// SPRG=51, 
	SPBRGH=0;
	SPBRG=51;
	BRGH=1; //high speed
	CREN=1; //enable receiver
	TXEN=1; // (register TXSTA) enable transmitter
	SYNC=0; // (register TXSTA) asynchronous operation
	SPEN=1; // (register RCSTA) set TX/CK as output, RX/DT as input
	//...by default: 8 bits, no interrupts
	
	// Motor control pinout
	TRISE0=DigitalOutput;
	TRISE1=DigitalOutput;
	TRISE2=DigitalOutput;
	TRISD7=DigitalOutput;
	TRISD6=DigitalOutput;
	TRISD5=DigitalOutput;
	
	// Lights pinout
	TRISD0=DigitalOutput;
	TRISD1=DigitalOutput;
	TRISD2=DigitalOutput;
	TRISD3=DigitalOutput;
	TRISD4=DigitalOutput;
	TRISA4=DigitalOutput;
	
	// Bumpers pinout
	/*RBIF=0;
	RBIE=1;
	GIE=1;
	IOCB=0b00000110;*/
	TRISB2=DigitalInput;
	TRISB1=DigitalInput;
	
	//default status
	BaseStop();
	LightFrontLeft=OFF;
	LightFrontRight=OFF;
	TestLed1=OFF;
	TestLed2=OFF;
	TestLed3=OFF;
	TestLed4=OFF;
}

bool PrevBumperFrontLeft=Released;
bool PrevBumperFrontRight=Released;

void ProcessSensors() {
	Delay(20);
	if(BumperFrontLeft==Pressed && PrevBumperFrontLeft==Released) {
		BaseStop();
		WriteSP(CcStatusBumper);
		WriteSP(CccBumperFrontLeftPressed);
	}
	if(BumperFrontLeft==Released && PrevBumperFrontLeft==Pressed) {
		WriteSP(CcStatusBumper);
		WriteSP(CccBumperFrontLeftReleased);
	}
	PrevBumperFrontLeft=BumperFrontLeft;

	if(BumperFrontRight==Pressed && PrevBumperFrontRight==Released) {
		BaseStop();
		//TestLed1=ON;
		WriteSP(CcStatusBumper);
		WriteSP(CccBumperFrontRightPressed);
	}
	 if(BumperFrontRight==Released && PrevBumperFrontRight==Pressed) {
		//TestLed1=OFF;
		WriteSP(CcStatusBumper);
		WriteSP(CccBumperFrontRightReleased);
	}
	PrevBumperFrontRight=BumperFrontRight;
}

void main() {	
	Setup();

	while(1) {
		ReceiveData();
		ProcessSensors();
	}
}


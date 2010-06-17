/*==================================================================
* Two-wheeled robot controlled from a computer
*
* CMSP-MAX MB_TX to MBP40 TX/CK (pin 25)
* CMSP-MAX MB_RX to MBP40 RX/DT (pin 26)
*
* Adrian Bulnes, aka Urriellu
* http://community.curuxa.org
*=================================================================*/
 
#include <MBP40.h> 

#define OSC_8MHz
#include <Delays.h>

// Lights
#define LightFrontLeft RD0
#define LightFrontRight RD1
#define ON 1
#define OFF 0

// Bumpers
#define BumperFrontLeft RB2
#define BumperFrontRight RB1
#define Pressed 0
#define Released 1

#include "SerialPort.h"
#include "Communication.h"

// Base movement
#define M1Enable RE0
#define M1In1 RE1
#define M1In2 RE2
#define M2Enable RD7
#define M2In1 RD6
#define M2In2 RD5
#include <L293.h>
#include "BaseMovement.h"

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
	
	// Bumpers pinout
	TRISB2=DigitalInput;
	TRISB1=DigitalInput;
	
	//default status
	BaseStop();
	LightFrontLeft=OFF;
	LightFrontRight=OFF;
}

void main() {	
	Setup();

	WriteSP('\n');
	WriteSP('I');
	WriteSP('N');
	WriteSP('I');
	WriteSP('T');
	WriteSP('\n');

	while(1) {
		ReceiveData();

		//if(BumperFrontLeft==Pressed) BaseMvFwd();
		//else BaseStop();

		//if(BumperFrontLeft==Pressed) WriteSP(56);

		//if(BumperFrontRight==Pressed) LightFrontLeft=ON;
		//else LightFrontLeft=OFF;
		
		/*MvFwd();
		DelaySec(1);
		MvBck();
		DelaySec(1);*/
	}
}


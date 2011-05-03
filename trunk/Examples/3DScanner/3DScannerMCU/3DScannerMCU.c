//Default template

#include <pic16f887.h>

typedef unsigned int config; config __at 0x2007 __CONFIG = _CP_OFF & _LVP_OFF & _WDT_OFF & _INTOSCIO & _DEBUG_OFF & _FCMEN_OFF & _IESO_OFF & _BOR_ON & _CPD_OFF & _MCLRE_OFF & _PWRTE_ON;

// list of control codes. This is the first byte transmitted through the serial port and indicates the operation being executed
//#define CcRESERVED 0
#define CcAuthID 1
#define CcActivateManualMode 100
#define CcManualSetPosH 101
#define CcManualSetPosV 102
#define CcManualTxValue 103

// CcAuthID - Identification (ID must be unique)
#define CccAuthID 97

// Lights
#define TestLed1 RD2
#define TestLed2 RD3
#define TestLed3 RD4
#define TestLed4 RA4
#define ON 1
#define OFF 0

// Variable types
#define int8 char

//Scanner mode
#define ModeInactive 0
#define ModeManual 1
#define ModeScan 2
unsigned int8 Mode;

// temp variable to store received data
unsigned int8 Rcv;

//Delay the program for 10 microseconds
void Delay10us(){
	__asm
		GOTO $+1
		GOTO $+1
		GOTO $+1
		GOTO $+1
		GOTO $+1
		GOTO $+1
		GOTO $+1
		GOTO $+1
		GOTO $+1
	__endasm;
}

//Delay the program for a given amount of milliseconds
void Delay(unsigned long ms){
	unsigned long i;
	while(ms--){
		for (i=0; i<118; i++) {
			//do nothing
		}
	}
}

// Clear UART errors
void ClearErrors(){
	unsigned int8 dummy;

	if (OERR) {
		TXEN=0;
		TXEN=1;
		CREN=0;
		CREN=1;
	}
	if (FERR) {
		dummy=RCREG;
		TXEN=0;
		TXEN=1;
	}
}

//Reads a byte from the serial port. If there is no data on the receiver buffer, wait indefinitely for the next incoming byte
unsigned int8 ReadSPWait(){
	while(!RCIF) {
		ClearErrors();
	}
	return RCREG;
}

//Reads a byte from the serial port. If there is no data on the receiver buffer, return 0xFF
unsigned int8 ReadSP() {
	if(RCIF) return RCREG;
	else {
		ClearErrors();
		return 0xFF;
	}
}

//Writes a byte to the serial port
void WriteSP(unsigned int8 value) {
	//wait for previous transmission to end
	while(!TXIF) {
		//do nothing
	}
	TXREG=value;
	Delay10us();
}

void Authenticate(){
	WriteSP(CcAuthID);
	WriteSP(CccAuthID);
}

// Parse any kind of data received
void ReceiveData() {
	Rcv=ReadSP();
	if(Rcv != 0xFF) {
		switch(Rcv) {
			case CcAuthID:
				Authenticate();
				break;
			//case CcSomething:
				//SetLight();
			//	break;
		}
	}
}

void Setup(){
	//Set the internal oscillator to 8MHz
	IRCF2=1;
	IRCF1=1;
	IRCF0=1;

	//Setup ADC (AN0) for distance-meter
	TRISA0=1; //set RA0 as digital input
	ANSEL=0b00000001; //set AN0 as analog input
	ANSELH=0;
	//use channel 0b000 (RA0/AN0) as the analog input for the ADC
	CHS3=0;
	CHS2=0;
	CHS1=0;
	CHS0=0;
	//Tad=Fosc/32=4us , Tconv=44-48us
	ADCS1=1;
	ADCS0=0;
	ADFM=1; //right justification, for 10 bits
	VCFG0=0; // Vdd as reference
	//VCFG0=1; // VRef+ as reference
	ADON=1;


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
	/*TRISE0=DigitalOutput;
	TRISE1=DigitalOutput;
	TRISE2=DigitalOutput;
	TRISD7=DigitalOutput;
	TRISD6=DigitalOutput;
	TRISD5=DigitalOutput;*/
	
	// Lights pinout
	/*TRISD0=DigitalOutput;
	TRISD1=DigitalOutput;
	TRISD2=DigitalOutput;
	TRISD3=DigitalOutput;
	TRISD4=DigitalOutput;
	TRISA4=DigitalOutput;*/
	
	// Buttons pinout
	//TRISB2=DigitalInput;
	//TRISB1=DigitalInput;
	
	//default status
	TestLed1=OFF;
	TestLed2=OFF;
	TestLed3=OFF;
	TestLed4=OFF;
	Mode=ModeManual;
}

void RunModeManual() {
	GO=1; //start measurement
	while(NOT_DONE) /*do nothing while making conversion*/;

	//Send data
	WriteSP(CcManualTxValue); // 1 - send control byte
	WriteSP(ADRESH); // 2 - Send ADC result (high byte)
	WriteSP(ADRESL); // 3 - Send ADC result (low byte)

	Delay(50);
}

void RunModeScan() {
	//NOT YET IMPLEMENTED
}

void main() {
	Setup();

	while(1) {
		//ReceiveData();
		//do something...
		switch(Mode){
			case ModeInactive:
				//do nothing
				break;
			case ModeManual:
				RunModeManual();
				break;
			case ModeScan:
				RunModeScan();
				break;
		}
	}
}

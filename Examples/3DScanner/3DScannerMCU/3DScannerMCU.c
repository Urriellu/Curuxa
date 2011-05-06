//Default template

#include <pic16f887.h>

typedef unsigned int config; config __at 0x2007 __CONFIG = _CP_OFF & _LVP_OFF & _WDT_OFF & _INTOSCIO & _DEBUG_OFF & _FCMEN_OFF & _IESO_OFF & _BOR_OFF & _CPD_OFF & _MCLRE_OFF & _PWRTE_ON;

// Variable types
#define int8 char

// list of control codes. This is the first byte transmitted through the serial port and indicates the operation being executed
//#define CcRESERVED 0
#define CcAuthID 1
#define CcActivateManualMode 100
#define CcManualSetPosH 101
#define CcManualSetPosV 102
#define CcManualTxValue 103
#define CcSetModeInactive 115

// CcAuthID - Identification (ID must be unique)
#define CccAuthID 97

// Lights
#define TestLedY RD0
#define TestLedR RD1
#define TestLedG RD2
#define ON 1
#define OFF 0

// Servomotors
#define ServoHpin RC2
#define ServoVpin RC1
unsigned int8 ServoH_ccpH;
unsigned int8 ServoH_ccpL;
unsigned int8 ServoV_ccpH;
unsigned int8 ServoV_ccpL;

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
	//Delay(50);
	WriteSP(CcAuthID);
	//Delay(50);
	WriteSP(CccAuthID);
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
	
	//setup PWM
	TRISC2=0;
	TRISC1=0;
	RC2=1;
	RC1=1;
	//CPP1, compare mode, clear bit on match
	CCP1M3=1;
	CCP1M2=0;
	CCP1M1=0;
	CCP1M0=1;
	//CPP2, compare mode, clear bit on match
	CCP2M3=1;
	CCP2M2=0;
	CCP2M1=0;
	CCP2M0=1;
	//default servo position
	/* 90º*/
	ServoH_ccpH=0xAD;
	ServoH_ccpL=0x2F;
	ServoV_ccpH=0xAD;
	ServoV_ccpL=0x2F;
	/* 0º (looks like 30º)
	ServoH_ccpH=0xA9;
	ServoH_ccpL=0x47;
	ServoV_ccpH=0xA9;
	ServoV_ccpL=0x47;*/
	/* 0º
	ServoH_ccpH=0xA7;
	ServoH_ccpL=0xB7;
	ServoV_ccpH=0xA7;
	ServoV_ccpL=0xB7;*/
	/* 180º
	ServoH_ccpH=0xB4;
	ServoH_ccpL=0x37;
	ServoV_ccpH=0xB4;
	ServoV_ccpL=0x37;*/
	//prescaler by default to 1:1
	//Timer1 by default using internal clock
	TMR1IF=0;
	TMR1IE=1;
	PEIE=1;
	GIE=1;
	TMR1ON=1;
	
	// Lights pinout
	TRISD0=0;
	TRISD1=0;
	TRISD2=0;	
	TestLedY=OFF;
	TestLedR=OFF;
	TestLedG=OFF;
	
	// Buttons pinout
	//TRISB2=DigitalInput;
	//TRISB1=DigitalInput;
	
	//default mode
	Mode=ModeInactive;
}

// Parse any kind of data received
void ReceiveData() {
	Rcv=ReadSP();
	if(Rcv != 0xFF) {
		switch(Rcv) {
			case CcAuthID:
				Authenticate();
				break;
			case CcActivateManualMode:
				Mode=ModeManual;
				break;
			case CcSetModeInactive:
				Mode=ModeInactive;
				break;
			case CcManualSetPosH:
				Rcv=ReadSPWait();
				ServoH_ccpH=ReadSPWait();
				ServoH_ccpL=ReadSPWait();
				break;
		}
	}
}

static void isr(void) __interrupt 0 {
	if(TMR1IF) {
		//start PWM high level
		TMR1ON=0;
		TMR1L=0x3F; //pre-load  Timer1
		TMR1H=0xA2;
		CCP1M3=0; //hack: deactivate CCP1/2 so we can control the pins manually
		CCP2M3=0;
		ServoHpin=1; //set high level of PWM
		ServoVpin=1;
		TMR1ON=1; //start Timer1 count
		CCP1M3=1; //hack: activate CCP1/2 again
		CCP2M3=1;
		TMR1IF=0;

		//set servo position (time at which the CCP modules
		//will set PWM pins to low (Compare Mode)
		CCPR1H=ServoH_ccpH;
		CCPR1L=ServoH_ccpL;
		CCPR2H=ServoV_ccpH;
		CCPR2L=ServoV_ccpL;
	} else {
		//unknown interrupt
		TestLedR=ON;
	}
}

void RunModeManual() {
	GO=1; //start measurement
	while(NOT_DONE) /*do nothing while making conversion*/;

	//Send data
	WriteSP(CcManualTxValue); // 1 - send control byte
	WriteSP(ADRESH); // 2 - Send ADC result (high byte)
	WriteSP(ADRESL); // 3 - Send ADC result (low byte)

	Delay(50); Delay(50); Delay(50); Delay(50);
}

void RunModeScan() {
	//NOT YET IMPLEMENTED
}

void main() {
	Setup();

	while(1) {
		ReceiveData();
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

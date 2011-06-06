//Default template

#include <pic16f887.h>

typedef unsigned int config; config __at 0x2007 __CONFIG = _CP_OFF & _LVP_OFF & _WDT_OFF & _INTOSCIO & _DEBUG_OFF & _FCMEN_OFF & _IESO_OFF & _BOR_OFF & _CPD_OFF & _MCLRE_OFF & _PWRTE_ON;

// Variable types
#define int8 char
#define bool unsigned int8
#define true 1
#define false 0

// list of control codes. This is the first byte transmitted through the serial port and indicates the operation being executed
//#define CcRESERVED 0
#define CcAuthID 1
#define CcError 2
#define CcTest 3
#define CcActivateManualMode 100
#define CcManualSetPosH 101
#define CcManualSetPosV 102
#define CcManualTxValue 103
#define CcSetModeInactive 115
#define CcSetModeScan 120
#define CcAutoTxValue 121
#define CcEndModeAutoScan 122

// CcAuthID - Identification (ID must be unique)
#define CccAuthID 97

// CcError
#define CccErrorUnknown 5
#define CccErrorOerr 7

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

//for counting 50ms
bool elapsed50ms;
unsigned int8 T0cycles;
#define T0preload 60

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
		//ClearErrors();
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
	while(!TRMT) {
		//wait to transmit
	}
	TXREG=value;
	//Delay10us();
	//Delay(1);
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
	SPEN=0; CREN=0; TXEN=0; RCIE=0; OERR=0; FERR=0; //reset to default to avoid problem on some restarts
	CREN=1; //enable receiver
	TXEN=1; // (register TXSTA) enable transmitter
	SYNC=0; // (register TXSTA) asynchronous operation
	RCIF=0;
	RCIE=1; //enable receiver interrupt
	SPEN=1; // (register RCSTA) set TX/CK as output, RX/DT as input
	//...by default: 8 bits, reciver interrupt
	
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
	TMR1ON=1;

	//setup TMR0 for 50ms
	//Fosc=8MHz, Fcy=2MHz, Tcy=0.5us, for 50ms -> 100000inst, prescaler 256 -> 390inst
	//we'll preload TMR0 to 60, so each overflow (prescaler 256) will happen every 25ms
	T0CS=0; //Fosc/4
	PSA=0; //prescaler for Timer0
	PS2=1; PS1=1; PS0=1; //prescaler 1:256
	T0cycles=0;
	
	// Lights pinout
	TRISD0=0;
	TRISD1=0;
	TRISD2=0;	
	TestLedY=OFF;
	TestLedR=OFF;
	TestLedG=OFF;
	
	//default mode
	Mode=ModeInactive;

	//begin interrupts
	PEIE=1;
	GIE=1;
}

// An error occurred. Send info to PC, turn on red LED and stop program
void Error(unsigned int8 ID){
	while(true) {
		GIE=0;
		WriteSP(CcError);
		WriteSP(ID);
		TestLedR=ON;
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
	} else if(RCIF) {
		//byte received
		Rcv=RCREG;
		switch(Rcv) {
			case CcAuthID:
				WriteSP(CcAuthID);
				WriteSP(CccAuthID);
				break;
			case CcTest:
				WriteSP(CcTest);
				WriteSP(51);
			case CcActivateManualMode:
				Mode=ModeManual;
				break;
			case CcSetModeInactive:
				Mode=ModeInactive;
				break;
			case CcManualSetPosH:
				ServoH_ccpH=ReadSPWait();
				ServoH_ccpL=ReadSPWait();
				break;
			case CcManualSetPosV:
				ServoV_ccpH=ReadSPWait();
				ServoV_ccpL=ReadSPWait();
				break;
			case CcSetModeScan:
				Mode=ModeScan;
				break;
		}
		if(OERR) Error(CccErrorOerr);
	} else if(T0IF){
		T0cycles++;
		TMR0=T0preload;
		if(T0cycles>=2){
			T0cycles=0;
			T0IE=0; //deactivate the count of 50ms until next time it's started
			elapsed50ms=true;
		}
		T0IF=0;
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

void StartCounting50ms(){
	elapsed50ms=false;
	T0IF=0;
	TMR0=T0preload;
	T0IE=1;
}

unsigned int last_ServoH_ccpH;
unsigned int last_ServoH_ccpL;
unsigned int last_ServoV_ccpH;
unsigned int last_ServoV_ccpL;

unsigned int8 MeasuresPerPoint;
unsigned int8 MinCcpH_msb;
unsigned int8 MinCcpH_lsb;
unsigned int8 MaxCcpH_msb;
unsigned int8 MaxCcpH_lsb;
unsigned int8 DutyIntervalH; //note, interval for duty, must be double for CPP
unsigned int8 MinCcpV_msb;
unsigned int8 MinCcpV_lsb;
unsigned int8 MaxCcpV_msb;
unsigned int8 MaxCcpV_lsb;
unsigned int8 DutyIntervalV; //note, interval for duty, must be double for CPP

unsigned int8 measInCurrPos;

#define HMovInc 0
#define HMovDec 1
unsigned int8 HMovDirection;

//check if, in automatic scan mode, the servos are already in the last position
bool InLastAutoPosition() {
	if(	last_ServoV_ccpH==MaxCcpV_msb
		&& last_ServoV_ccpL==MaxCcpV_lsb
		&& last_ServoH_ccpH==MaxCcpH_msb
		&& last_ServoH_ccpL==MaxCcpH_lsb ) {
		return true;
	} else return false;
}

//check if, in automatic scan mode, the horizontal servo is at the last position
bool InLastAutoHPos() {
	if(ServoH_ccpH==MaxCcpH_msb && ServoH_ccpL==MaxCcpH_lsb) return true;
	else return false;
}

void MoveAutoFirstHPos() {
	ServoH_ccpH=MinCcpH_msb;
	ServoH_ccpL=MinCcpH_lsb;
}

void MoveAutoLastHPos() {
	ServoH_ccpH=MaxCcpH_msb;
	ServoH_ccpL=MaxCcpH_lsb;
}

//in automatic mode, move to next row
void MoveAutoNextRow(){
	unsigned int temp;

	MoveAutoFirstHPos();
	
	//increment ServoV_ccpX twice
	temp=ServoV_ccpL;	ServoV_ccpL+=DutyIntervalV; if(ServoV_ccpL<=temp) ServoV_ccpH++;
	temp=ServoV_ccpL; ServoV_ccpL+=DutyIntervalV; if(ServoV_ccpL<=temp) ServoV_ccpH++;

	TMR1IE=1; Delay(1000); TMR1IE=0; //wait for the new line to start
}

//in automatic mode, move to next horizontal position
void MoveAutoNextHPos(){
	unsigned int temp;
	
	//increment ServoH_ccpX twice
	temp=ServoH_ccpL;	ServoH_ccpL+=DutyIntervalH; if(ServoH_ccpL<=temp) ServoH_ccpH++;
	temp=ServoH_ccpL; ServoH_ccpL+=DutyIntervalH; if(ServoH_ccpL<=temp) ServoH_ccpH++;
}

//in automatic mode, check if the horizontal position is too high (that is, because of the increment we are over the limit indicated by the user)
bool IsHPosTooHigh() {
	if(ServoH_ccpH>MaxCcpH_msb || (ServoH_ccpH==MaxCcpH_msb && ServoH_ccpL>MaxCcpH_lsb)) return true;
	else return false;
}

bool IsRowTooHigh() {
	if(ServoV_ccpH>MaxCcpV_msb || (ServoV_ccpH==MaxCcpV_msb && ServoV_ccpL>MaxCcpV_lsb)) return true;
	else return false;
}

//in automatic mode, move servos to next position
void MoveAutoNextPos() {
	measInCurrPos++;

	if(measInCurrPos>MeasuresPerPoint) {
		measInCurrPos=0;

		TMR1IE=0; //disable Timer1 so servos don't update their position with incomplete information
		if(InLastAutoHPos()) {
			//if last H position, go to next row
			MoveAutoNextRow();
		} else {
			//next horizontal position
			MoveAutoNextHPos();
			if(IsHPosTooHigh()) MoveAutoLastHPos();
		}
		TMR1IE=1;
	} else {
		//don't move, we still have to make take more measurements in this position
	}
}

void RunModeScan() {
	RCIE=0; //disable serial port received interrupts

	MeasuresPerPoint=ReadSPWait();
	MinCcpH_msb=ReadSPWait();
	MinCcpH_lsb=ReadSPWait();
	MaxCcpH_msb=ReadSPWait();
	MaxCcpH_lsb=ReadSPWait();
	DutyIntervalH=ReadSPWait();
	MinCcpV_msb=ReadSPWait();
	MinCcpV_lsb=ReadSPWait();
	MaxCcpV_msb=ReadSPWait();
	MaxCcpV_lsb=ReadSPWait();
	DutyIntervalV=ReadSPWait();

	HMovDirection=HMovInc;
	measInCurrPos=0;

	//move to first position and wait 1 second (maybe the servos need to move a lot)
	TMR1IE=0;
	ServoH_ccpH=MinCcpH_msb;
	ServoH_ccpL=MinCcpH_lsb;
	ServoV_ccpH=MinCcpV_msb;
	ServoV_ccpL=MinCcpV_lsb;
	TMR1IE=1;
	StartCounting50ms(); Delay(1000);

	do{
		//wait until time ends, so servos arrive to proper destination
		while(!elapsed50ms) /*wait*/ ;

		//start measurement
		GO=1;

		//move to next position while ADC is working
		last_ServoH_ccpH=ServoH_ccpH;
		last_ServoH_ccpL=ServoH_ccpL;
		last_ServoV_ccpH=ServoV_ccpH;
		last_ServoV_ccpL=ServoV_ccpL;
		MoveAutoNextPos();

		//start counting time so we give enough time for the servos to move
		StartCounting50ms();

		//wait for ADC to finish
		while(NOT_DONE) /*wait*/ ;

		//send info to PC
		WriteSP(CcAutoTxValue); // 1 - send control byte
		WriteSP(last_ServoH_ccpH); // 2 - send position of servos for last position (when measurement began)
		WriteSP(last_ServoH_ccpL);
		WriteSP(last_ServoV_ccpH);
		WriteSP(last_ServoV_ccpL);
		WriteSP(ADRESH); // 3 - Send ADC result (high byte)
		WriteSP(ADRESL); // low byte
	} while(!IsRowTooHigh());

	WriteSP(CcEndModeAutoScan);

	RCIF=0; RCIE=1;
}

void main() {
	Setup();

	while(true) {
		//ReceiveData();
		//do something...
		switch(Mode){
			case ModeInactive:
				ClearErrors();
				RCIF=0; RCIE=1;
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

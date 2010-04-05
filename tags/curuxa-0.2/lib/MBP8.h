/*==================================================================
* Library for MBP8 using a PIC12F683
* http://curuxa.org
*=================================================================*/

#include <pic12f683.h>
#include <MBP.h>

#define ADC_MAX_VALUE 1024

#define Interrupt void Intr(void) __interrupt 0
#define interrupt Interrupt
#define ISR Interrupt

#define SetDigitalInput(pin) SetBit(TRISIO,pin)
#define SetDigitalOutput(pin) ClearBit(TRISIO,pin)

//Disable Analog-to-Digital converter
void AdcDisable(){
	ADON=0;
	ANSEL=0;
}

//Set AN2 as analog input, and use it as the source for the ADC conversion
void EnableAN2(){
	SetBit(TRISIO, 2);
	ANS2=1;
	CHS1=1;
	CHS0=0;
}

//Set AN3 as analog input, and use it as the source for the ADC conversion
void EnableAN3(){
	SetBit(TRISIO, 4);
	ANS3=1;
	CHS1=1;
	CHS0=1;
}

//Synchcronously get the analog value on the active analog input. It waits doing nothing until the measurement is done
unsigned int16 AdcMeasure(){
	ADFM=1;
	ADON=1;
	GO=1;
	while(NOT_DONE) /*do nothing*/;
	return ADRESH << 8 | ADRESL;
}

//Set the internal oscillator to 8MHz
void SetIntosc8MHz(){
	IRCF2=1;
	IRCF1=1;
	IRCF0=1;
}

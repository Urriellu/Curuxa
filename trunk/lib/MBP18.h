/*==================================================================
* Library for MBP18 using a PIC16F88
* http://curuxa.org
*=================================================================*/

#include <pic16f88.h>
#include <MBP.h>

#define ADC_MAX_VALUE 1024

//Set the internal oscillator to 31.25kHz
void SetIntosc31kHz(){
	IRCF2=0;
	IRCF1=0;
	IRCF0=0;
}

//Set the internal oscillator to 8MHz
void SetIntosc8MHz(){
	IRCF2=1;
	IRCF1=1;
	IRCF0=1;
}

//Enable Timer 0 interrupts
/*void T0EnInt{
	
}

//Setup timer 0 at
void SetTmr0*/

//Disable Analog-to-Digital converter
void AdcDisable(){
	ADON=0;
	ANSEL=0;
}

//Set AN0 as analog input, and use it as the source for the ADC conversion
void EnableAN0(){
	TRISA0=1;
	ANSEL&=0b00000001;
	CHS2=0;
	CHS1=0;
	CHS0=0;
}

//Synchcronously get the analog value on the active analog input. It waits doing nothing until the measurement is done
unsigned int16 AdcMeasure(){
	ADFM=1;
	ADON=1;
	GO=1;
	while(NOT_DONE) /*do nothing*/;
	return ADRESH << 8 | ADRESL;
}

//Enable ADC interrupt
void AdcEnableInt(){
	ADIF=0;
	ADIE=1;
}

//Disable ADC interrupt
void AdcDisableInt(){
	ADIE=0;
}

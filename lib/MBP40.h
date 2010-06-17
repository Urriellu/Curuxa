/*==================================================================
* Library for MBP40 using a PIC16F887
* http://curuxa.org
*=================================================================*/

#include <pic16f887.h>
#include <MBP.h>

#define Interrupt static void isr(void) interrupt 0
#define ISR Interrupt

#define ADC_MAX_VALUE 1024

//Disable Analog-to-Digital converter
void AdcDisable(){
	ADON=0;
	ANSEL=0;
	ANSELH=0;
}

//Set the internal oscillator to 8MHz
void SetIntosc8MHz(){
	IRCF2=1;
	IRCF1=1;
	IRCF0=1;
}
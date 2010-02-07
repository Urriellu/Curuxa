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

//Disable Analog-to-Digital converter
void AdcDisable(){
	ADON=0;
	ANSEL=0;
}

//Set AN0 as analog input, and use it as the source for the ADC conversion
void EnableAN3(){
	SetBit(TRISIO, 4);
	SetBit(ANSEL, 3);
	CHS2=0;
	CHS1=0;
	CHS0=0;
}

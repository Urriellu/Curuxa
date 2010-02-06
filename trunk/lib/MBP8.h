/*==================================================================
* Library for MBP8 using a PIC12F683
* http://curuxa.org
*=================================================================*/

#include <pic12f683.h>
#include <MBP.h>

#define ADC_MAX_VALUE 1024

//Disable Analog-to-Digital converter
void AdcDisable(){
	ADON=0;
	ANSEL=0;
}

//Set AN0 as analog input, and use it as the source for the ADC conversion
void EnableAN3(){
	TRISIO4=DigitalInput;
	ANSEL&=0b00001000;
	CHS2=0;
	CHS1=0;
	CHS0=0;
}

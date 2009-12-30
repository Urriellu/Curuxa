/*==================================================================
* Sample program for AO-SPK using an MBP18
*
* Plug AO-SPK to RA1 (pin 18).
*
* http://curuxa.org
*=================================================================*/

#define OSC_8MHz

#include <MBP18.h>
#include <Delays.h>

ConfigBits1(_CP_OFF & _DEBUG_OFF & _WRT_PROTECT_OFF & _CPD_OFF & _LVP_OFF & _BODEN_OFF & _MCLR_OFF & _PWRTE_ON & _WDT_OFF & _INTRC_IO);

#define Spk RA1

void Setup(){
	//set all pins as digital, instead of analog inputs
	ANSEL=0;

	//set RA1 as a digital output
	TRISA1=DigitalOutput;

	SetIntosc8MHz();
}

void main(){
	Setup();

	while(1){
		Spk=!Spk;
		Delay(1);
	}
}


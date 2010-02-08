/*==================================================================
* Sample program for AO-SPK using an MBP8
*
* Plug AO-SPK to GP5 (pin 2).
*
* http://curuxa.org
*=================================================================*/

#define OSC_8MHz

#include <MBP8.h>
#include <Delays.h>

ConfigBits(_CPD_OFF & _CP_OFF & _BOD_OFF  & _MCLRE_OFF & _PWRTE_ON & _WDT_OFF & _INTOSCIO);

#define Spk GP5

void Setup() {
	AdcDisable();
	SetDigitalOutput(5);
	SetIntosc8MHz();
}


void main() {
	Setup();

	while(1) {
		Spk=!Spk;
		Delay(1);
	}
}




/*==================================================================
* Simple digital Theremin using MBP8, AO-SPK and SIDST-GP2
*
* Plug AO-SPK to GP5 (pin 2).
* Plug SIDST-GP2 to AN3 (pin 3).
*
* http://curuxa.org
*=================================================================*/

#include <MBP8.h>

ConfigBits(_CPD_OFF & _CP_OFF & _BOD_OFF  & _MCLRE_OFF & _PWRTE_ON & _WDT_OFF & _INTOSCIO);

#define Spk GP51

static void isr(void) interrupt 0 (){
	Spk=!Spk;
	TMR0IF=0;
}

void main() {
	//setup ADC
	AdcDisable();
	EnableAN3();
	TRISIO5=DigitalOutput;

	//setup timer
	PSA=0;
	T0CS=0;
	TMR0IF=0;
	GIE=1;
	TMR0IE=1;

	while(1){
		//do something here...
	}
}

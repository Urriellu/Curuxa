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

#define Spk GP5

Interrupt {
	Spk=!Spk;
	PR2=0;
	TMR2IF=0;
}

void main() {
	//setup ADC
	//AdcDisable();
	//EnableAN3();

	//setup speaker
	ClearBit(TRISIO, 5);
	Spk=1;

	//setup timer
	//PIC12F683 runs at 4MHz by default
	//Fosc=4MHz, Tosc=250ns, Tcy=1us
	//for a 440Hz tone whe need a 880Hz timer frequency. That's 1136 instructions per cycle
	//...1:1 postscaler (TOUTPS=0b0000).  1:16 prescaler (T2CKPS=0b10). PR2=71
	TOUTPS3=0;
	TOUTPS2=0;
	TOUTPS1=0;
	TOUTPS0=0;
	T2CKPS1=1;
	T2CKPS0=0;
	PR2=71;
	TMR2IF=0;
	GIE=1;
	TMR2IE=1;
	TMR2ON=1;

	while(1) {
	}
}

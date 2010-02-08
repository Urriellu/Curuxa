/*==================================================================
* Simple digital Theremin using MBP8, AO-SPK and SIDST-GP2
*
* Plug AO-SPK to GP5 (pin 2).
* Plug SIDST-GP2 to AN3 (pin 3).
*
* http://curuxa.org
*=================================================================*/

#include <MBP8.h>
#include <GP2.h>

ConfigBits(_CPD_OFF & _CP_OFF & _BOD_OFF  & _MCLRE_OFF & _PWRTE_ON & _WDT_OFF & _INTOSCIO);

#define Spk GP5

unsigned int8 preload;

Interrupt {
	Spk=!Spk;
	TMR0=preload;
	T0IF=0;
}

void Setup() {
	//setup ADC
	AdcDisable();
	EnableAN3();

	SetDigitalOutput(5);
        SetIntosc8MHz();
	
	//setup timer
	//PIC12F683 runs by default at 4MHz
	//Fosc=4MHz, Tosc=250ns, Tcy=1us
	//for a 440Hz tone whe need a 880Hz timer frequency. That's 1136 instructions per cycle
	//...1:8 prescaler (PS=0b010). 142 TMR0 counts  per cycle. preload=114	
	PSA=0; //assign prescaler to Timer0
	T0CS=0; //clock source=internal oscillator
	PS2=0; //prescaler... 
	PS1=1;
	PS0=0;
	T0IF=0;
	GIE=1; //enable global interrupts
	T0IE=1; //enable TMR0 interrupt
}



void main() {
	unsigned int16 ADC=0;
	Setup();

	while(1) {
		ADC=AdcMeasure();
		if(ADC<100) {
			//player's hand too far away, do nothing
			TMR0=preload;
		} else {
			ADC-=154;
			ADC>>=1;
			ADC+=114;
			preload=(unsigned int8)ADC;
		}
	}
}

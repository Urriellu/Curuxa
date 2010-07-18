/*==================================================================
* Sample program for AO-SPK using MBP8 Timer0
*
* Plug AO-SPK to GP5 (pin 2).
*
* http://curuxa.org
*=================================================================*/

#include <MBP8.h>

ConfigBits(_CPD_OFF & _CP_OFF & _BOD_OFF  & _MCLRE_OFF & _PWRTE_ON & _WDT_OFF & _INTOSCIO);

#define Spk GP5

Interrupt {
	Spk=!Spk;
	TMR0=114;
	T0IF=0;
}

void Setup() {
	AdcDisable();
	SetDigitalOutput(5);
	
	//setup timer
	//PIC12F683 runs by default at 4MHz
	//Fosc=4MHz, Tosc=250ns, Tcy=1us
	//for a 440Hz tone whe need a 880Hz timer frequency. That's 1136 instructions per cycle
	//...1:8 prescaler (PS=0b010). 142 TMR0 counts  per cycle. preload=114	
	PSA=0; //assign prescaler to Timer0
	T0CS=0; //clock source=internal oscillator
	PS2=0;
 //prescaler...
 	PS1=1;
	PS0=0;
	T0IF=0;
	GIE=1; //enable global interrupts
	T0IE=1; //enable TMR0 interrupt
}


void main() {
	Setup();

	while(1) {
		//do nothing
	}
}


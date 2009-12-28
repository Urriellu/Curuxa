/*==================================================================
* Sample program for LTIND-A using an MBP18
*
* This program configures all available pins as digital outputs.
* Plug Module LTIND-A to any pin. It will light up and then
* stop every second. RA5 is an input-only pin, so the LED will
* not light there
* Note: PIC16F88 runs by default at 31.25kHz (internal oscillator)
*
* http://curuxa.org
*=================================================================*/

#include <pic16f88.h>

typedef unsigned int config;
config at _CONFIG1 __CONFIG = _CP_OFF & _DEBUG_OFF & _WRT_PROTECT_OFF & _CPD_OFF & _LVP_OFF & _BODEN_OFF & _MCLR_OFF & _PWRTE_ON & _WDT_OFF & _INTRC_IO;

//Simple delay for an unspecified amount of time
void Delay(){
    long i;

    for (i=0; i<200; i++) {
        //do nothing
    }
}

void main(){
	//set all pins as digital, instead of analog inputs
	ANSEL=0;

	//set all digital pins as outputs
	TRISA=0;
	TRISB=0;

	while(1){
	    //Turn LED on
		PORTA=0b11111111;
		PORTB=0b11111111;
		Delay();

        //Turn LED off
		PORTA=0;
		PORTB=0;
		Delay();
	}
}


/*==================================================================
* Sample program for MBP18 using a PIC16F88
*
* This program configures all available pins as digital outputs.
* You can check that all digital pins are set at the same voltage as
* the power source using a voltmeter or Module LTIND-A (the LED
* should light up)
* Note: RA5 is an input-only pin
*
* http://curuxa.org
*=================================================================*/

#include <pic16f88.h>

typedef unsigned int config;
config at _CONFIG1 __CONFIG = _CP_OFF & _DEBUG_OFF & _WRT_PROTECT_OFF & _CPD_OFF & _LVP_OFF & _BODEN_OFF & _MCLR_OFF & _PWRTE_ON & _WDT_OFF & _INTRC_IO;

void main(){
	//set all pins as digital, instead of analog inputs
	ANSEL=0;

	//set all digital pins as outputs
	TRISA=0;
	TRISB=0;

	while(1){
		PORTA=0b11111111;
		PORTB=0b11111111;
	}
}

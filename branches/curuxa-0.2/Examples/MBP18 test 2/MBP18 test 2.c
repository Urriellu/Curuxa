/*==================================================================
* Sample program for MBP18 using a PIC16F88, with Curuxa libraries
*
* This program configures all available pins as digital outputs.
* You can check that all digital pins are set at the same voltage as
* the power source using a voltmeter or Module LTIND-A (the LED
* should light up)
* Note: RA5 (pin 4) is an input-only pin
*
* http://curuxa.org
*=================================================================*/

#include <MBP18.h>

ConfigBits1(_CP_OFF & _DEBUG_OFF & _WRT_PROTECT_OFF & _CPD_OFF & _LVP_OFF & _BODEN_OFF & _MCLR_OFF & _PWRTE_ON & _WDT_OFF & _INTRC_IO);

void main() {
	//set all pins as digital, instead of analog inputs
	AdcDisable();

	//set all digital pins as outputs
	TRISA=AllDigitalOutputs;
	TRISB=AllDigitalOutputs;

	while(1) {
		//set all digital output pins at Vcc
		PORTA=0b11111111;
		PORTB=0b11111111;
	}
}


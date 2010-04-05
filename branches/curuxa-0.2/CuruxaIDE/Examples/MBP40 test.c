/*==================================================================
* Sample program for MBP40 with Curuxa libraries
*
* This program configures all available pins as digital outputs.
* You can check that all digital pins are set at the same voltage as
* the power source using a voltmeter or Module LTIND-A (the LED
* should light up)
* Note: RE3 (pin 1) is an input-only pin
*
* http://curuxa.org
*=================================================================*/

#include <MBP40.h>

ConfigBits1(_CP_OFF & _DEBUG_OFF & _FCMEN_OFF  & _IESO_OFF & _CPD_OFF & _LVP_OFF & _BOR_OFF & _MCLRE_OFF & _PWRTE_ON & _WDT_OFF & _INTOSCIO);

void main() {
	//set all pins as digital, instead of analog inputs
	AdcDisable();

	//set all digital pins as outputs
	TRISA=AllDigitalOutputs;
	TRISB=AllDigitalOutputs;
	TRISC=AllDigitalOutputs;
	TRISD=AllDigitalOutputs;
	TRISE=AllDigitalOutputs;

	while(1) {
		//set all digital output pins at Vcc
		PORTA=0b11111111;
		PORTB=0b11111111;
		PORTC=0b11111111;
		PORTD=0b11111111;
		PORTE=0b11111111;
	}
}

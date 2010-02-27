/*==================================================================
* Sample program for LTIND-A using an MBP40
*
* This program configures all available pins as digital outputs.
* Plug Module LTIND-A to any pin. It will light up and then
* stop every second. RE3 (pin 1) is an input-only pin, so the LED will
* not light there
* Note: PIC16F887 runs by default at 4MHz (internal oscillator)
*
* http://curuxa.org
*=================================================================*/

#include <MBP40.h>

ConfigBits1(_CP_OFF & _DEBUG_OFF & _FCMEN_OFF  & _IESO_OFF & _CPD_OFF & _LVP_OFF & _BOR_OFF & _MCLRE_OFF & _PWRTE_ON & _WDT_OFF & _INTOSCIO);

#define OSC_8MHz
#include <Delays.h>

void main() {
	SetIntosc8MHz();
	AdcDisable();

	TRISA=AllDigitalOutputs;
	TRISB=AllDigitalOutputs;
	TRISC=AllDigitalOutputs;
	TRISD=AllDigitalOutputs;
	TRISE=AllDigitalOutputs;

	while(1) {
		PORTA=0b11111111;
		PORTB=0b11111111;
		PORTC=0b11111111;
		PORTD=0b11111111;
		PORTE=0b11111111;
		DelaySec(1);

		PORTA=0;
		PORTB=0;
		PORTC=0;
		PORTD=0;
		PORTE=0;
		DelaySec(1);
	}
}
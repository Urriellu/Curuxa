/*==================================================================
* Sample program for MBP8 using a PIC12F683
*
* This program configures all available pins as digital outputs.
* You can check that all digital pins are set at the same voltage as
* the power source using a voltmeter or Module LTIND-A (the LED
* should light up)
* Note: GP3 (pin 4) is an input-only pin
*
* http://curuxa.org
*=================================================================*/
 
#include <MBP8.h>
 
ConfigBits(_CPD_OFF & _CP_OFF & _BOD_OFF  & _MCLRE_OFF & _PWRTE_ON & _WDT_OFF & _INTOSCIO);
 
void main() {
        AdcDisable();
 
        //set all digital pins as outputs
        TRISIO=AllDigitalOutputs;
 
        while(1) {
                GPIO=0b11111111;
	}
}


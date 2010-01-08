/*==================================================================
* Sample program for MBP14 using a PIC16F688
*
* This program configures all available pins as digital outputs.
* You can check that all digital pins are set at the same voltage as
* the power source using a voltmeter or Module LTIND-A (the LED
* should light up)
* Note: RA3 (pin 4) is an input-only pin
*
* http://curuxa.org
*=================================================================*/
 
#include <MBP14.h>
 
ConfigBits( _CPD_OFF & _CP_OFF & _BOD_OFF  & _MCLRE_OFF & _PWRTE_ON & _WDT_OFF & _INTOSCIO);
 
void main(){
        AdcDisable();
 
        //set all digital pins as outputs
        TRISA=AllDigitalOutputs;
        TRISC=AllDigitalOutputs;
 
        while(1){
                PORTA=0b11111111;
                PORTC=0b11111111;
	}
}

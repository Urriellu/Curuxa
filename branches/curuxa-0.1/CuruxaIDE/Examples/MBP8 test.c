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
 
#include <pic12f683.h>
 
typedef unsigned int config;
config at 0x2007 __CONFIG = _CPD_OFF & _CP_OFF & _BOD_OFF  & _MCLRE_OFF & _PWRTE_ON & _WDT_OFF & _INTOSCIO;
 
void main() {
        //set all pins as digital, instead of analog inputs
        ANSEL=0;
 
        //set all digital pins as outputs
        TRISIO=0;
 
        while(1){
                GPIO=0b11111111;
	}
}        


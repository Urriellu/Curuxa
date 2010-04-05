/*==================================================================
* Sample program for SIDST-GP2 using an MBP18
*
* Plug SIDST-GP2 to RA0/AN0 (pin 17) and LTIND-A to RB4 (pin 10).
* The LED will light up when there is an object closer than 25cm
*
* http://curuxa.org
*=================================================================*/

#include <MBP18.h>
#include <GP2.h>

ConfigBits1(_CP_OFF & _DEBUG_OFF & _WRT_PROTECT_OFF & _CPD_OFF & _LVP_OFF & _BODEN_OFF & _MCLR_OFF & _PWRTE_ON & _WDT_OFF & _INTRC_IO);

#define LED RB4
#define LedON 1
#define LedOFF 0

void main() {
	TRISB4=0;
	EnableAN0();

	while(1) {
		//note: distance and ADC values are inversely proportional
		if(AdcMeasure() > GP2_25cm) LED=LedON;
                else LED=LedOFF;
	}
}

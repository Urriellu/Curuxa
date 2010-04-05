/*==================================================================
* Sample program for LTIND-A and SISW-SPST using an MBP18
*
* Plug SISW-SPST to RB3 (pin 9) and LTIND-A to RB4 (pin 10).
* The LED will light up while the button is pressed.
*
* http://curuxa.org
*=================================================================*/

#include <pic16f88.h>

typedef unsigned int config;
config at _CONFIG1 __CONFIG = _CP_OFF & _DEBUG_OFF & _WRT_PROTECT_OFF & _CPD_OFF & _LVP_OFF & _BODEN_OFF & _MCLR_OFF & _PWRTE_ON & _WDT_OFF & _INTRC_IO;

#define Button RB3
#define Pressed 0
#define Released 1

#define LED RB4
#define LedON 1
#define LedOFF 0

void main(){
	//set RB3 as a digital input and RB4 as a digital output
	TRISB3=1;
	TRISB4=0;

	while(1){
                if(Button==Pressed) LED=LedON;
                else LED=LedOFF;
	}
}



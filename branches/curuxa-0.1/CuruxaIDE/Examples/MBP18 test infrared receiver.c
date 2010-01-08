/*==================================================================
* Sample program for CMIR-RC and LTIND-A using an MBP18
*
* Plug CMIR-RC to RB3 (pin 9) and LTIND-A to RB4 (pin 10).
* The LED will flick while you are pressing a button on your
* remote control
*
* http://curuxa.org
*=================================================================*/

#include <MBP18.h>

ConfigBits1(_CP_OFF & _DEBUG_OFF & _WRT_PROTECT_OFF & _CPD_OFF & _LVP_OFF & _BODEN_OFF & _MCLR_OFF & _PWRTE_ON & _WDT_OFF & _INTRC_IO);

#define IrReceiver RB3

#define LED RB4
#define LedON 1
#define LedOFF 0

void main(){
	//set RB3 as a digital input and RB4 as a digital output
	TRISB3=DigitalInput;
	TRISB4=DigitalOutput;

	while(1){
                if(IrReceiver==0) LED=LedON;
                else LED=LedOFF;
	}
}

/*==================================================================
* Sample program for LTIND-A and SIBW-1Y using an MBP18
*
* Plug SIBW-1Y to RB3 (pin 9) and LTIND-A to RB4 (pin 10).
* The LED will light up when there is a white or reflective object very close to the sensor (less than 1cm, aprox
*
* http://curuxa.org
*=================================================================*/

#include <MBP18.h>

ConfigBits1(_CP_OFF & _DEBUG_OFF & _WRT_PROTECT_OFF & _CPD_OFF & _LVP_OFF & _BODEN_OFF & _MCLR_OFF & _PWRTE_ON & _WDT_OFF & _INTRC_IO);

#define Sensor RB3
#define White 0
#define Black 1

#define LED RB4
#define LedON 1
#define LedOFF 0

void main() {
	TRISB3=DigitalInput;
	TRISB4=DigitalOutput;

	while(1){
                if(Sensor==White) LED=LedON;
                else LED=LedOFF;
	}
}



/*==================================================================
* Main source code file for SampleOctopod
*
* Settings:
* Left motor: Motor 1
* Right motor: Motor 2
* Infrared receiver: RB0 (pin 6)
*
* Adrian Bulnes
*
* http://community.curuxa.org
*
*=================================================================*/

#include <MBP18.h>

ConfigBits1(_CP_OFF & _DEBUG_OFF & _WRT_PROTECT_OFF & _CPD_OFF & _LVP_OFF & _BODEN_OFF & _MCLR_OFF & _PWRTE_ON & _WDT_OFF & _INTRC_IO);

#define OSC_8MHz
#include <Delays.h>

//Pinout
#define M1Enable RA2
#define M1In1 RA3   
#define M1In2 RA4   
#define M2Enable RA1
#define M2In1 RA0   
#define M2In2 RA7   
#define RC RB0      

#include <L293.h>
#include "BaseMovement.h"

void Setup(){
        AdcDisable();

	TRISA0=DigitalOutput;
	TRISA1=DigitalOutput;
	TRISA2=DigitalOutput;
	TRISA3=DigitalOutput;
	TRISA4=DigitalOutput;
	TRISA7=DigitalOutput;
	TRISB0=DigitalInput; 

	SetIntosc8MHz();
}                   

void main(){
	int i=0;

        Setup();

	Stop();

        while(1){
                if(RC==0) i++;
		else i=0;
		if(i>5){
			MvFwd(); DelaySec(5);
			RotateL(); DelaySec(3);
			MvFwd(); DelaySec(6);
			RotateR(); DelaySec(6);
			MvFwd(); DelaySec(6);
			RotateL(); DelaySec(3);
			MvFwd(); DelaySec(7);
			Stop();
		}
	}
}

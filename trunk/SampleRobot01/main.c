/*==================================================================
* Main source code file for SampleRobot01
*
* http://curuxa.org
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

#include <L293.h>
#include "BaseMovement.h"

void Setup(){
	//set all pins as digital, instead of analog inputs
	ANSEL=0;

	//set RA1 as a digital output
	TRISA0=DigitalOutput;
	TRISA1=DigitalOutput;
	TRISA2=DigitalOutput;
	TRISA3=DigitalOutput;
	TRISA4=DigitalOutput;
	TRISA7=DigitalOutput;
	
    SetIntosc8MHz();
}

void main(){
	Setup();
	
	while(1){
		MvFwd();
		DelaySec(1);
		MvBck();
		DelaySec(1);
	}
}

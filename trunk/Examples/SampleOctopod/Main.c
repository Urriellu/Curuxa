/*==================================================================
* Main source code file for SampleOctopod
*
* http://curuxa.org
*
* Settings:
* Left motor: Motor 1
* Right motor: Motor 2
* Infrared receiver: RB0 (pin 6)
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
        DisableADC();

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
        Setup();

        while(1){
                if(RC==0) {
                        MvFwd();
                        DelaySec(1);
                }
                else Stop();
        }
}

//test everything works
/*void main(){
        Setup();

        while(1){
                if(RC==0) {
                        MvFwd();
                        DelaySec(1);
                }
                else Stop();
        }
}*/
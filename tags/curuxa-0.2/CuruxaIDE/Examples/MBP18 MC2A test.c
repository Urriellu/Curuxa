/*==================================================================
* Sample program for MC2A using MBP18
*
* Motor 1 begins moving forward, then backwards, then it stops
* and motor 2 begins moving forward, then backwards, then it stops
* and motor 1 begins moving forward...
*
* Note: PIC16F88 runs by default at 31.25kHz (internal oscillator)
*
* http://curuxa.org
*=================================================================*/
 
#include <pic16f88.h>
 
typedef unsigned int config;
config at _CONFIG1 __CONFIG = _CP_OFF & _DEBUG_OFF & _WRT_PROTECT_OFF & _CPD_OFF & _LVP_OFF & _BODEN_OFF & _MCLR_OFF & _PWRTE_ON & _WDT_OFF & _INTRC_IO;
 
//Pinout
#define M1Enable Rxx
#define M1In1 Rxx
#define M1In2 Rxx
#define M2Enable Rxx
#define M2In1 Rxx
#define M2In2 Rxx
 
//Move motor 1 forward
void M1Fwd(){
        M1Enable=1;
        M1In1=1;
        M1In2=0;
}
 
//Move motor 1 backwards
void M1Bck(){
        M1Enable=1;
        M1In1=0;
        M1In2=1;
}
 
//Brake motor 1 electrically
void M1Brake(){
        M1Enable=1;
        M1In1=0;
        M1In2=0;
}
 
//Motor 1 spins free
void M1Free(){
        M1Enable=0;
}
 
//Move motor 2 forward
void M2Fwd(){
        M2Enable=1;
        M2In1=1;
        M2In2=0;
}
 
//Move motor 2 backwards
void M2Bck(){
        M2Enable=1;
        M2In1=0;
        M2In2=1;
}
 
//Brake motor 2 electrically
void M2Brake(){
        M2Enable=1;
        M2In1=0;
        M2In2=0;
}
 
//Motor 2 spins free
void M2Free(){
        M2Enable=0;
}
 
//Simple delay for an unspecified amount of time
void Delay(){
    long i;
 
    for (i=0; i<200; i++) {
        //do nothing
    }
}
 
void main(){
        //configure data pins as digital outputs
        ANSEL=0;
        TRISA=(edit this);
        TRISB=(edit this);
 
        while(1){
                M1Fwd();
                Delay();
                M1Bck();
                Delay();
                M1Brake();
 
                M2Fwd();
                Delay();
                M2Bck();
                Delay();
                M2Brake();
  
	}
}
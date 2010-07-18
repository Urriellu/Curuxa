/*==================================================================
* Sample program for LT7S-HN using MBP40
*
* This program uses an LT7S-HN with 6 displays and 7 segments and no dot point,
* plus a SISW-SPST. All displays and segments light up when the button is NOT
* pressed, and they turn off when it is pressed.
*
* http://curuxa.org
*=================================================================*/
 
#include <MBP40.h> 
 
ConfigBits1(_CP_OFF & _DEBUG_OFF & _FCMEN_OFF  & _IESO_OFF & _CPD_OFF & _LVP_OFF & _BOR_OFF & _MCLRE_OFF & _PWRTE_ON & _WDT_OFF & _INTOSCIO);

//displays
#define D1 RE2
#define D2 RE1
#define D3 RE0
#define D4 RA5
#define D5 RA4
#define D6 RA3

//segments
#define SA RD1
#define SB RD0
#define SC RC3
#define SD RC2
#define SE RC1
#define SF RC0
#define SG RA6

#define ON 1
#define OFF 0

#define Button RB0
#define Pressed 0
#define Released 1

void main() {
 	AdcDisable();
 
	TRISE2=DigitalOutput;
	TRISE1=DigitalOutput;
	TRISE0=DigitalOutput;
	TRISA5=DigitalOutput;
	TRISA4=DigitalOutput;
	TRISA3=DigitalOutput;
	TRISD1=DigitalOutput;
	TRISD0=DigitalOutput;
	TRISC3=DigitalOutput;
	TRISC2=DigitalOutput;
	TRISC1=DigitalOutput;
	TRISC0=DigitalOutput;
	TRISA6=DigitalOutput;

	TRISB0=DigitalInput;

	while(1) {
		if(Button==Released){
			D1=ON;
			D2=ON;
			D3=ON;
			D4=ON;
			D5=ON;
			D6=ON;
			SA=ON;
			SB=ON;
			SC=ON;
			SD=ON;
			SE=ON;
			SF=ON;
			SG=ON;
		} else {
			D1=OFF;
			D2=OFF;
			D3=OFF;
			D4=OFF;
			D5=OFF;
			D6=OFF;
			SA=OFF;
			SB=OFF;
			SC=OFF;
			SD=OFF;
			SE=OFF;
			SF=OFF;
			SG=OFF;
		}
	}
}

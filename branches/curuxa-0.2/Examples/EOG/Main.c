/*==================================================================
* Electrooculograph
*
* Connections:
* EOG module: RA0/AN0 (pin 17)
* SISW-SPST: RB3 (pin 9)
* AO-SPK: RA1 (pin 18)
* One LTIND-A: RA2 (pin 1)
* Another LTIND-A: RA3 (pin 2)
*
* Each LED will light up and a different sound will be generated
* based on which direction the subject is looking to.
*
* While the button is pressed, both LEDs will be off, the speaker
* will be muted, and the EOG will enter calibration-mode.
*
* http://curuxa.org
*
*=================================================================*/

#include <MBP18.h>

#define OSC_8MHz
#include <Delays.h>

ConfigBits1(_CP_OFF & _DEBUG_OFF & _WRT_PROTECT_OFF & _CPD_OFF & _LVP_OFF & _BODEN_OFF & _MCLR_OFF & _PWRTE_ON & _WDT_OFF & _INTRC_IO);

#define Button RB3
#define Pressed 0
#define Released 1

#define LED_R RA2
#define LED_L RA3
#define LedON 1
#define LedOFF 0

#define SquareOut RA1

bool calibrating;

Interrupt {
	if(!calibrating) SquareOut=!SquareOut;
	TMR0IF=0;
}

//Looking to the right
void LookR(){
	LED_R=LedON;
	LED_L=LedOFF;

	//prescaler=16, 488Hz
	PS2=0;
	PS1=1;
	PS0=1;
}

//Looking to the left
void LookL(){
	LED_R=LedOFF;
	LED_L=LedON;

	//prescaler=32, 244Hz
	PS2=1;
	PS1=0;
	PS0=0;
}

void main() {
        //setup
	unsigned int8 i;
        float center=0;
        float val=0;
	calibrating=true;
        SetIntosc8MHz();
        EnableAN0();
	TRISA1=DigitalOutput;
	TRISA2=DigitalOutput;
	TRISA3=DigitalOutput;
        TRISB3=DigitalInput;
	PSA=0;
	T0CS=0;
	TMR0IF=0;
	GIE=1;
	TMR0IE=1;
	SquareOut=0;

	//wait for calibration
	while(Button==Released) {
		LED_R=LedON;
		LED_L=LedON;
	}

        while(1) {
		//calibrate center voltage while button is pressed
                while(Button==Pressed) {
			calibrating=true;
			center=(center*0.99+AdcMeasure()*0.01);
		}
		calibrating=false;

		//average of 200 measurements
		val=0;
		for(i=0; i<200; i++) {
			val+=AdcMeasure();
		}
		val/=200;

                if(val>center) LookR();
                else LookL();
        }
}

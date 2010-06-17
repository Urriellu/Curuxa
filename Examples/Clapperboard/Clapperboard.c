/*==================================================================
* Clapperboard
*
* Adrian Bulnes, aka Urriellu
* http://community.curuxa.org
*=================================================================*/
 
#include <MBP40.h> 

#define OSC_8MHz
#include <Delays.h>
 
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

#define LED RD3

//segments and LED control
#define ON 1
#define OFF 0

//BUTTONS
//...group 1, 2, 3. Up/down:
#define G1u RB0
#define G1d RB1
#define G2u RB2
#define G2d RB3
#define G3u RB4
#define G3d RB5
//...standby button:
#define ButtonSB RD2
//...control:
#define Pressed 0
#define Released 1

//delay between displays (time each display is ON)
#define CommonDelay() Delay(1)

//delay after button press
#define ButtonDelay() Delay(20);

unsigned int8 G1[2];
unsigned int8 G2[2];
unsigned int8 G3[2];

void AllSegmOn(){
	SA=ON;
	SB=ON;
	SC=ON;
	SD=ON;
	SE=ON;
	SF=ON;
	SG=ON;
}

void AllSegmOff(){
	SA=OFF;
	SB=OFF;
	SC=OFF;
	SD=OFF;
	SE=OFF;
	SF=OFF;
	SG=OFF;
}

void AllDispOn(){
	D1=ON;
	D2=ON;
	D3=ON;
	D4=ON;
	D5=ON;
	D6=ON;
}

void AllDispOff(){
	D1=OFF;
	D2=OFF;
	D3=OFF;
	D4=OFF;
	D5=OFF;
	D6=OFF;
}

void SetSegm(unsigned int8 n){
	switch(n){
		case 0:
			SA=ON;
			SB=ON;
			SC=ON;
			SD=ON;
			SE=ON;
			SF=ON;
			SG=OFF;
			break;
		case 1:
			SA=OFF;
			SB=ON;
			SC=ON;
			SD=OFF;
			SE=OFF;
			SF=OFF;
			SG=OFF;
			break;
		case 2:
			SA=ON;
			SB=ON;
			SC=OFF;
			SD=ON;
			SE=ON;
			SF=OFF;
			SG=ON;
			break;
		case 3:
			SA=ON;
			SB=ON;
			SC=ON;
			SD=ON;
			SE=OFF;
			SF=OFF;
			SG=ON;
			break;
		case 4:
			SA=OFF;
			SB=ON;
			SC=ON;
			SD=OFF;
			SE=OFF;
			SF=ON;
			SG=ON;
			break;
		case 5:
			SA=ON;
			SB=OFF;
			SC=ON;
			SD=ON;
			SE=OFF;
			SF=ON;
			SG=ON;
			break;
		case 6:
			SA=ON;
			SB=OFF;
			SC=ON;
			SD=ON;
			SE=ON;
			SF=ON;
			SG=ON;
			break;
		case 7:
			SA=ON;
			SB=ON;
			SC=ON;
			SD=OFF;
			SE=OFF;
			SF=OFF;
			SG=OFF;
			break;
		case 8:
			SA=ON;
			SB=ON;
			SC=ON;
			SD=ON;
			SE=ON;
			SF=ON;
			SG=ON;
			break;
		case 9:
			SA=ON;
			SB=ON;
			SC=ON;
			SD=OFF;
			SE=OFF;
			SF=ON;
			SG=ON;
			break;
		default:
			SA=OFF;
			SB=OFF;
			SC=OFF;
			SD=OFF;
			SE=OFF;
			SF=OFF;
			SG=OFF;
			break;
	}
}

void main() {
	SetIntosc8MHz();
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

	TRISD3=DigitalOutput;
	
	TRISB0=DigitalInput;
	TRISB1=DigitalInput;
	TRISB2=DigitalInput;
	TRISB3=DigitalInput;
	TRISB4=DigitalInput;
	TRISB5=DigitalInput;

	//default values
	G1[0]=0;
	G1[1]=0;
	G2[0]=0;
	G2[1]=0;
	G3[0]=0;
	G3[1]=0;

	//checking LEDs...
	while(ButtonSB==Released) {
		AllSegmOn();
		AllDispOn();
		LED=ON;
	}
	ButtonDelay();
	while(ButtonSB==Pressed) ;
	ButtonDelay();
	
	//main loop
	while(1){
		LED=ON;

		//update values
		if(G1u==Pressed) {
			ButtonDelay();
			G1[0]++;
			if(G1[0]>9) {
				G1[0]=0;
				G1[1]++;
			}
			if(G1[1]>9) {
				G1[1]=0;
			}
			while(G1u==Pressed) ;
		}

		if(G1d==Pressed) {
			ButtonDelay();
			if(G1[0]!=0) G1[0]--;
			else {
				G1[0]=9;
				if(G1[1]!=0) G1[1]--;
				else G1[1]=9;
			}
			while(G1d==Pressed);
		}
		
		if(G2u==Pressed) {
			ButtonDelay();
			G2[0]++;
			if(G2[0]>9) {
				G2[0]=0;
				G2[1]++;
			}
			if(G2[1]>9) {
				G2[1]=0;
			}
			while(G2u==Pressed) ;
		}

		if(G2d==Pressed) {
			ButtonDelay();
			if(G2[0]!=0) G2[0]--;
			else {
				G2[0]=9;
				if(G2[1]!=0) G2[1]--;
				else G2[1]=9;
			}
			while(G2d==Pressed);
		}

		if(G3u==Pressed) {
			ButtonDelay();
			G3[0]++;
			if(G3[0]>9) {
				G3[0]=0;
				G3[1]++;
			}
			if(G3[1]>9) {
				G3[1]=0;
			}
			while(G3u==Pressed) ;
		}

		if(G3d==Pressed) {
			ButtonDelay();
			if(G3[0]!=0) G3[0]--;
			else {
				G3[0]=9;
				if(G3[1]!=0) G3[1]--;
				else G3[1]=9;
			}
			while(G3d==Pressed);
		}

		//show numbers
		SetSegm(G1[0]);
		D1=ON;
		CommonDelay();
		D1=OFF,

		SetSegm(G1[1]);
		D2=ON;
		CommonDelay();
		D2=OFF,

		SetSegm(G2[0]);
		D3=ON;
		CommonDelay();
		D3=OFF;

		SetSegm(G2[1]);
		D4=ON;
		CommonDelay();
		D4=OFF;

		SetSegm(G3[0]);
		D5=ON;
		CommonDelay();
		D5=OFF;

		SetSegm(G3[1]);
		D6=ON;
		CommonDelay();
		D6=OFF;

		//stand-by mode
		if(ButtonSB==Pressed){
			ButtonDelay();
			while(ButtonSB==Pressed) ; //wait for button release
			ButtonDelay();
			AllDispOff();
			while(ButtonSB==Released) {
				LED=!LED;
				Delay(100);
			}
			while(ButtonSB==Pressed) ; 
		}
	}
}



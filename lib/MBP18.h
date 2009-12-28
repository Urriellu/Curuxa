/*==================================================================
* Library for MBP18 using a PIC16F88
* http://curuxa.org
*=================================================================*/

#include <pic16f88.h>
#include <MBP.h>

//Set the internal oscillator to 31.25kHz
void SetIntosc31kHz(){
	IRCF2=0;
	IRCF1=0;
	IRCF0=0;
}

//Set the internal oscillator to 8MHz
void SetIntosc8MHz(){
	IRCF2=1;
	IRCF1=1;
	IRCF0=1;
}

//Enable Timer 0 interrupts
/*void T0EnInt{
	
}

//Setup timer 0 at
void SetTmr0*/

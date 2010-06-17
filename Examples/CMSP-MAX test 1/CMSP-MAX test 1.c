/*==================================================================
* Sample program for CMSP-MAX (transmission-only) using MBP40
*
* This program sends consecutive numbers through the serial port.
* It's the most simple way to check for proper transmission from the
* microcontroller to the computer.
*
* Connect MB_TX from CMSP-MAX to TX/CK (pin 25) on MBP40
*
* http://curuxa.org
*=================================================================*/
 
#include <MBP40.h> 

#define OSC_8MHz
#include <Delays.h>
 
ConfigBits1(_CP_OFF & _DEBUG_OFF & _FCMEN_OFF  & _IESO_OFF & _CPD_OFF & _LVP_OFF & _BOR_OFF & _MCLRE_OFF & _PWRTE_ON & _WDT_OFF & _INTOSCIO);

//Writes a byte to the serial port
void WriteSP(unsigned int8 value){
	//wait for previous transmission to end
	while(!TXIF){
		//do nothing
	}
	TXREG=value;
	Delay10us();
}

void main() {
	unsigned int8 i=13;

	SetIntosc8MHz();
	AdcDisable();

	//setup UART, transmission
	//Baud rate timer: SPBRG=((Fosc/(16 * 9600) -1))
	//Baud rate = Fosc/(16*(SPBRG+1))
	//real resulting baud rate for Fosc=8MHz: 9615.384615 bauds
	// SPRG=51, 
	SPBRGH=0;
	SPBRG=51;
	BRGH=1; //high speed
	TXEN=1; // (register TXSTA) enable transmitter
	SYNC=0; // (register TXSTA) asynchronous operation
	SPEN=1; // (register RCSTA) set TX/CK as output
	//...by default: 8 bits, no interrupts

	WriteSP('h');
	WriteSP('e');
	WriteSP('l');
	WriteSP('l');
	WriteSP('o');

	while(1){
		WriteSP(i);
		i++;
	}
}


/*==================================================================
* Sample program for CMSP-MAX using MBP40
*
* This program reads a byte from the serial port and sends back three bytes:
* 1- The same byte as received
* 2- The received byte plus one
* 3- The received byte plus two
* For example, if you send a 57 (single byte) from the computer, it will
* send back a 57, 58 and 59.
*
* Connect MB_TX from CMSP-MAX to TX/CK (pin 25) on MBP40
* Connect MB_RXfrom CMSP-MAX to RX/DT (pin 26) on MBP40
*
* http://curuxa.org
*=================================================================*/
 
#include <MBP40.h> 

#define OSC_8MHz
#include <Delays.h>
 
ConfigBits1(_CP_OFF & _DEBUG_OFF & _FCMEN_OFF  & _IESO_OFF & _CPD_OFF & _LVP_OFF & _BOR_OFF & _MCLRE_OFF & _PWRTE_ON & _WDT_OFF & _INTOSCIO);

//Writes a byte to the serial port
void WriteSP(unsigned int8 value) {
	//wait for previous transmission to end
	while(!TXIF) {
		//do nothing
	}
	TXREG=value;
	Delay10us();
}

//Reads a byte from the serial port. If there is no data on the receiver buffer, wait indefinitely for the next incoming byte
unsigned int8 ReadSPWait(){
	unsigned int8 dummy;
	while(!RCIF) {
		if (OERR) {
			TXEN=0;
			TXEN=1;
			CREN=0;
			CREN=1;
		}
		if (FERR) {
			dummy=RCREG;
			TXEN=0;
			TXEN=1;
		}
	}
	return RCREG;
}

//Reads a byte from the serial port. If there is no data on the receiver buffer, return 0xFF
unsigned int8 ReadSP() {
	if(RCIF) return RCREG;
	else return 0xFF;
}

void main() {
	unsigned int8 i=0;

	SetIntosc8MHz();
	AdcDisable();

	//setup UART
	//Baud rate timer: SPBRG=((Fosc/(16 * 9600) -1))
	//Baud rate = Fosc/(16*(SPBRG+1))
	//real resulting baud rate for Fosc=8MHz: 9615.384615 bauds
	// SPRG=51, 
	SPBRGH=0;
	SPBRG=51;
	BRGH=1; //high speed
	CREN=1; //enable receiver
	TXEN=1; // (register TXSTA) enable transmitter
	SYNC=0; // (register TXSTA) asynchronous operation
	SPEN=1; // (register RCSTA) set TX/CK as output, RX/DT as input
	//...by default: 8 bits, no interrupts

	WriteSP('\n');
	WriteSP('i');
	WriteSP('n');
	WriteSP('i');
	WriteSP('t');

	while(1) {
		i=ReadSP();
		if(i!=0xFF) {
			WriteSP(i);
			i++;
			WriteSP(i);
			i++;
			WriteSP(i);
		}
	}
}


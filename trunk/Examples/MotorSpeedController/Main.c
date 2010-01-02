//MBP18 template

#include <MBP18.h>

ConfigBits1(_CP_OFF & _DEBUG_OFF & _WRT_PROTECT_OFF & _CPD_OFF & _LVP_OFF & _BODEN_OFF & _MCLR_OFF & _PWRTE_ON & _WDT_OFF & _INTRC_IO);

void main() {	
	PORTB=0;
	TRISB=0;

	while(1){
		PORTB++;
	}
}

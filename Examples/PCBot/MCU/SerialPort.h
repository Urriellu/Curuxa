﻿//Reads a byte from the serial port. If there is no data on the receiver buffer, wait indefinitely for the next incoming byte
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

//Writes a byte to the serial port
void WriteSP(unsigned int8 value) {
	//wait for previous transmission to end
	while(!TXIF) {
		//do nothing
	}
	TXREG=value;
	Delay10us();
}


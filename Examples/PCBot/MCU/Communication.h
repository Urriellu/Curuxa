﻿// list of control codes. This is the first byte transmitted through the serial port and indicates the operation being done

//#define CcRESERVED 0
#define CcAuthID 1
#define CcSetLight 10
#define CcSetBaseMovement 11
#define CcStatusLight 100
#define CcStatusBaseMovement 101
//#define CcRESERVED 255



//==========================================================================
// Codes used by individual operations

// CcAuthID - Identification
#define CccAuthID 13

// CcSetLight, CcStatusLight - Receive/send status of a light
#define CccLightFrontLeftOn 50
#define CccLightFrontLeftOff 51
#define CccLightFrontRightOn 52
#define CccLightFrontRightOff 52

// CcSetBaseMovement, CcStatusBaseMovement - Receive/send status of base movement
#define CccBaseMvFwd 20
#define CccBaseMvStop 21
#define CccBaseMvBck 22
#define CccBaseTurnL 23
#define CccBaseTurnR 24
#define CccBaseRotateL 25
#define CccBaseRotateR 26

// temp variable to store received data
unsigned int8 Rcv;

// Received an instruction to set lights
void SetLight(){
	Rcv=ReadSPWait();
	switch(Rcv) {
		case CccLightFrontLeftOn:
			LightFrontLeft=ON;
			break;
		case CccLightFrontLeftOff:
			LightFrontLeft=OFF;
			break;
	}
}

// Parse any kind of data received
void ReceiveData() {
	Rcv=ReadSP();
	if(Rcv != 0xFF) {
		switch(Rcv) {
			case CcSetLight:
				SetLight();
				break;
		}
	}
}


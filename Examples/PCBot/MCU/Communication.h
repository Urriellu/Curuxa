// temp variable to store received data
unsigned int8 Rcv;

void Authenticate(){
	WriteSP(CcAuthID);
	WriteSP(CccAuthID);
}

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
		case CccLightFrontRightOn:
			LightFrontRight=ON;
			break;
		case CccLightFrontRightOff:
			LightFrontRight=OFF;
			break;
	}
}

//Received an instruction to set the movement of the base
void SetBaseMv(){
	Rcv=ReadSPWait();
	switch(Rcv) {
		case CccBaseMvFwd:
			BaseMvFwd();
			break;
		case CccBaseMvStop:
			BaseStop();
			break;
		case CccBaseMvBck:
			BaseMvBck();
			break;
		case CccBaseTurnL:
			BaseTurnL();
			break;
		case CccBaseTurnR:
			BaseTurnR();
			break;
		case CccBaseRotateL:
			BaseRotateL();
			break;
		case CccBaseRotateR:
			BaseRotateR();
			break;
	}
}

// Parse any kind of data received
void ReceiveData() {
	Rcv=ReadSP();
	if(Rcv != 0xFF) {
		switch(Rcv) {
			case CcAuthID:
				Authenticate();
				break;
			case CcSetLight:
				SetLight();
				break;
			case CcSetBaseMovement:
				SetBaseMv();
				break;
		}
	}
}


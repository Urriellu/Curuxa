unsigned int8 BaseMvStatus = CccBaseMvStop;

void SendBaseMvStatus() {
	WriteSP(CcStatusBaseMovement);
	WriteSP(BaseMvStatus);
}

//remove this
//Move robot forward
void BaseMvFwd(){
	M1Fwd();
	M2Fwd();
	BaseMvStatus=CccBaseMvFwd;
	SendBaseMvStatus();
}

//Stop robot
void BaseStop(){
	M1Free();
	M2Free();
	BaseMvStatus=CccBaseMvStop;
	SendBaseMvStatus();
}

//Move backwards
void BaseMvBck(){
	M1Bck();
	M2Bck();
	BaseMvStatus=CccBaseMvBck;
	SendBaseMvStatus();
}

//Turn left
void BaseTurnL(){
	M1Free();
	M2Fwd();
	BaseMvStatus=CccBaseTurnL;
	SendBaseMvStatus();
}

//Turn right
void BaseTurnR(){
	M1Fwd();
	M2Free();
	BaseMvStatus=CccBaseTurnR;
	SendBaseMvStatus();
}

//Rotate left
void BaseRotateL(){
	M1Bck();
	M2Fwd();
	BaseMvStatus=CccBaseRotateL;
	SendBaseMvStatus();
}

//Rotate right
void BaseRotateR(){
	M1Fwd();
	M2Bck();
	BaseMvStatus=CccBaseRotateR;
	SendBaseMvStatus();
}

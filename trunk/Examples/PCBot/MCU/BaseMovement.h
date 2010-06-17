unsigned int8 BaseMvStatus = CccBaseMvStop;
//remove this
//Move robot forward
void BaseMvFwd(){
	M1Fwd();
	M2Fwd();
}

//Stop robot
void BaseStop(){
	M1Free();
	M2Free();
}

//Move backwards
void BaseMvBck(){
	M1Bck();
	M2Bck();
}

//Turn left
void BaseTurnL(){
	M1Free();
	M2Fwd();
}

//Turn right
void BaseTurnR(){
	M1Fwd();
	M2Free();
}

//Rotate left
void BaseRotateL(){
	M1Bck();
	M2Fwd();
}

//Rotate right
void BaseRotateR(){
	M1Fwd();
	M2Bck();
}

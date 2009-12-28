//Move robot forward
void MvFwd(){
	M1Fwd();
	M2Fwd();
}

//Stop robot
void Stop(){
	M1Free();
	M2Free();
}

//Move backwards
void MvBck(){
	M1Bck();
	M2Bck();
}

//Turn left
void TurnL(){
	M1Free();
	M2Fwd();
}

//Turn right
void TurnR(){
	M1Fwd();
	M2Free();
}

//Rotate left
void RotateL(){
	M1Bck();
	M2Fwd();
}

//Rotate right
void RotateR(){
	M1Fwd();
	M2Bck();
}

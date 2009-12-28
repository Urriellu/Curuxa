/*==================================================================
* Library for L293 motor controller
* http://curuxa.org
*=================================================================*/


/* Before using this library, the following defines must be set to 
match the digital pins your L293 is plugged to:

M1Enable, M1In1, M1In2, M2Enable, M2In1, M2In2


For example (put this in MyProgram.c):

#define M1Enable RA2
#define M1In1 RA3
#define M1In2 RA4
#define M2Enable RA1
#define M2In1 RA0
#define M2In2 RA7
*/

//Move motor 1 forward
void M1Fwd(){
	M1Enable=1;
	M1In1=1;
	M1In2=0;
}
 
//Move motor 1 backwards
void M1Bck(){
	M1Enable=1;
	M1In1=0;
	M1In2=1;
}
 
//Brake motor 1 electrically
void M1Brake(){
	M1Enable=1;
	M1In1=0;
	M1In2=0;
}
 
//Motor 1 spins free
void M1Free(){
	M1Enable=0;
}
 
//Move motor 2 forward
void M2Fwd(){
	M2Enable=1;
	M2In1=1;
	M2In2=0;
}
 
//Move motor 2 backwards
void M2Bck(){
	M2Enable=1;
	M2In1=0;
	M2In2=1;
}
 
//Brake motor 2 electrically
void M2Brake(){
	M2Enable=1;
	M2In1=0;
	M2In2=0;
}
 
//Motor 2 spins free
void M2Free(){
	M2Enable=0;
}

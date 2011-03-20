/*==================================================================
* Library for features shared between all MBP (using PICs)
* http://curuxa.org
*=================================================================*/

#define int8 char
#define int16 int
#define int32 long

#define bool unsigned int8
#define true 1
#define TRUE 1
#define false 0
#define FALSE 0

#define DigitalInput 1
#define DigitalOutput 0
#define AllDigitalInputs 0xFF
#define AllDigitalOutputs 0x00

#define ConfigBits(bits) typedef unsigned int config; config __at 0x2007 __CONFIG = bits
#define ConfigBits1(bits) typedef unsigned int config; config __at _CONFIG1 __CONFIG = bits

#define SetBit(v,bit) v |= (1 << bit);
#define ClearBit(v,bit) v &= ~(1 << bit);
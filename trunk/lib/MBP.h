/*==================================================================
* Library for features shared between all MBP (using PICs)
* http://curuxa.org
*=================================================================*/

#define DigitalInput 1
#define DigitalOutput 0

#define ConfigBits1(bits) typedef unsigned int config; config at _CONFIG1 __CONFIG = bits

/*==================================================================
* Delays for PICs
*
* Warning 1:
* These delays keep the PIC doing nothing, wasting time and energy.
* Use timers and interrupts if you want to execute something
* else while waiting
*
* Warning 2: these functions are very inexact. For better timing
* use internal timers. For precission timing use Real Time Clocks.
*
* Before using this library you must define one of the following values:
* OSC_8MHz

* For example:
* #define OSC_8MHz
*
* http://curuxa.org
*=================================================================*/

//Delay the program for 10 microseconds
void Delay10us(){
	#ifdef OSC_8MHz
	__asm
		GOTO $+1
		GOTO $+1
		GOTO $+1
		GOTO $+1
		GOTO $+1
		GOTO $+1
		GOTO $+1
		GOTO $+1
		GOTO $+1
	__endasm;
	#else
		#error Oscillator frequency not set. Put '#define OSC_8MHz' (or your oscillator freq) before '#include <Delays.h>'
	#endif
}

//Delay the program for a given amount of milliseconds
void Delay(unsigned long ms){
	#ifdef OSC_8MHz
	unsigned long i;
	while(ms--){
		for (i=0; i<118; i++) {
			//do nothing
		}
	}
	#else
		#error Oscillator frequency not set. Put '#define OSC_8MHz' (or your oscillator freq) before '#include <Delays.h>'
	#endif
}

//Delay the program for a given amount of seconds
void DelaySec(unsigned long seconds){
	#ifdef OSC_8MHz
	while(seconds--){
		Delay(950);
	}
	#else
		#error Oscillator frequency not set. Put '#define OSC_8MHz' (or your oscillator freq) before '#include <Delays.h>'
	#endif
}

//Delay the program for a given amount of minutes
void DelayMin(unsigned long minutes){
	#ifdef OSC_8MHz
	while(minutes--){
		Delay(55);
	}
	#else
		#error Oscillator frequency not set. Put '#define OSC_8MHz' (or your oscillator freq) before '#include <Delays.h>'
	#endif
}


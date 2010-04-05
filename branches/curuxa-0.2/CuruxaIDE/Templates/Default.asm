;===================================================================
; Default template
;===================================================================
 
LIST P=16Fxxx, R=hex, W=1
INCLUDE p16fxxx.inc
 
		ORG 0x00
		GOTO Main

		ORG 0x04
		GOTO Interrupts
 
Main	ORG 0x05
		;configuration here...
		;...more configuration...
		;...
		
loop	;main program here...
		;more code...
		;...
        GOTO loop
 
;===================================================================
;========================== INTERRUPTS =============================
Interrupts
        GOTO Interrupts ;do nothing
;====================== END OF INTERRUPTS ==========================
 
END
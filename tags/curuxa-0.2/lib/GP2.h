/*==================================================================
* Library for managing GP2D-12 / GP2Y0A21YK
* http://curuxa.org
*=================================================================*/

/* TOO MUCH MEMORY CONSUMPTION

//voltage at each distance
#define V6cm 3.1
#define V25cm 1.1
#define V80cm 0.4

//ADC values at each distance
float D6cm, D25cm, D80cm;

void GP2Setup(float SupplyVoltage){
	D6cm=ADC_MAX_VALUE/SupplyVoltage*V6cm;
	D25cm=ADC_MAX_VALUE/SupplyVoltage*V25cm;
	D80cm=ADC_MAX_VALUE/SupplyVoltage*V80cm;
}

//Convert the digital value from the ADC to centimeters
unsigned int8 Gp2AdcToCm(unsigned int16 ADC){
	float cm, a, b, ADC1, ADC2;
	unsigned int8 L1, L2;
	
	if(ADC>D25cm) {
		//measuring less than 25cm
		L1=6;
		L2=25;
		ADC1=D6cm;
		ADC2=D25cm;
	} else {
		L1=25;
		L2=80;
		ADC1=D25cm;
		ADC2=D80cm;
	}
	
	//cm=a-b*ADC
	b=((float)(L2-L1))/(ADC1-ADC2);
	a=b*ADC1+L1;
	cm=a-b*ADC;
	return (unsigned int8)cm;
}*/

//digital values for distances when Vcc=5V
//Warning: values and distances are inversely proportional, this means a value bigger than GP2_10cm is actually closer than 10cm
#define GP2_6cm  635
#define GP2_10cm 471
#define GP2_15cm 338
#define GP2_25cm 225
#define GP2_40cm 154
#define GP2_80cm 82


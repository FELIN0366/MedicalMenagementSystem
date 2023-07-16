//��cpp�ļ������˺����������壬ʵ�ֻ�����Ϣ�ķ��ؽӿ�
#include"infoClass.h"
#include"infoReturnPatient.h"


//return patient's id
const char* getPatientID(const char * s)
{
	patient p(s);
	return p.returnID();
}

//return patient's name
const char* getPatientName(const char* s)
{
	patient p(s);
	return p.returnName();
}

//return patient's case number
const char* getPatientCaseNumber(const char* s)
{
	patient p(s);
	return p.returnCaseNumber();
}

//return patient's birth date
const char* getPatientBirthDate(const char* s)
{
	patient p(s);
	return p.returnBirthDate();
}

//return patient's age
const char* getPatientAge(const char* s)
{
	patient p(s);
	return p.returnAge();
}

//return patient's sex
const char* getPatientSex(const char* s)
{
	patient p(s);
	return p.returnSex();
}
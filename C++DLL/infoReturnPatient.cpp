//此cpp文件补充了函数完整定义，实现患者信息的返回接口
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
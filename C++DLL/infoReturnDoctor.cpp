#include"infoClass.h"
#include"infoReturnDcotor.h"

//return doctor's id
const char* getDoctorID(const char* s)
{
	doctor d(s);
	return d.returnID();
}

//return doctor's name
const char* getDoctorName(const char* s)
{
	doctor d(s);
	return d.returnName();
}

//return doctor's employee number
const char* getDoctorEmployeeNumber(const char* s)
{
	doctor d(s);
	return d.returnEmployeeNumber();
}

//return doctor's department
const char* getDoctorDepartment(const char* s)
{
	doctor d(s);
	return d.returnDepartment();
}
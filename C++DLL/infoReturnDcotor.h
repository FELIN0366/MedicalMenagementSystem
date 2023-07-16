#pragma once
#include<mysql.h>
#include<string>
//methods that used to return basic information of doctor after login

extern "C" __declspec(dllexport) const char* getDoctorID(const char* s);

extern "C" __declspec(dllexport) const char* getDoctorName(const char* s);

extern "C" __declspec(dllexport) const char* getDoctorEmployeeNumber(const char* s);

extern "C" __declspec(dllexport) const char* getDoctorDepartment(const char* s);
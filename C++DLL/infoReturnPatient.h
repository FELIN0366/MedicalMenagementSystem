#pragma once
#include<mysql.h>
#include<string>
//methods that used to return basic information of patient after login

extern "C" __declspec(dllexport) const char* getPatientID(const char* s);

extern "C" __declspec(dllexport) const char* getPatientName(const char* s);

extern "C" __declspec(dllexport) const char* getPatientCaseNumber(const char* s);

extern "C" __declspec(dllexport) const char* getPatientBirthDate(const char* s);

extern "C" __declspec(dllexport) const char* getPatientAge(const char* s);

extern "C" __declspec(dllexport) const char* getPatientSex(const char* s);
#pragma once
#include<mysql.h>
#include<string>
#include"transCoding.h"

//return doctor's name search by id
extern "C" __declspec(dllexport) const char* IDToDoctorName(const char* s);
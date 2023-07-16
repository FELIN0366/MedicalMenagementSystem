#pragma once
#include<mysql.h>
#include<string>

//return id search by patient's case number
extern "C" __declspec(dllexport) const char* caseNumberToID(const char* s);

//return case number search by patient's id
extern "C" __declspec(dllexport) const char* IDToCaseNumber(const char* s);

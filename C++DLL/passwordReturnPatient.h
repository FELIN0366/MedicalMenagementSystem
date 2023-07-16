#pragma once
#include<mysql.h>
#include<string>

//return patient's password
extern "C" __declspec(dllexport) const char* returnPasswordPatient(const char*s);

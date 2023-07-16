#pragma once
#include<mysql.h>
#include<string>

//return doctor's password
extern "C" __declspec(dllexport) const char* returnPasswordDoctor(const char*s);
#pragma once
#include<mysql.h>
#include<string>

//return administrator's password
extern "C" __declspec(dllexport) const char* returnPasswordAdministrator(const char* s);
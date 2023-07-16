#pragma once
#include"mysql.h"
#include <string>
#include <iostream>
#include <exception>

//MySQL transcoding problem : convert utf-8 to unicode
wchar_t* Utf8_2_Unicode(char* row_i);

//MySQL transcoding problem
char* WcharToChar(wchar_t* wp);


//when data from MySQL is Chinese, it need to change from utf-8 to unicode
char* transCoding(char* c);

#include"transCoding.h"

//convert utf-8 to unicode
wchar_t* Utf8_2_Unicode(char* row_i)
{
	int len = MultiByteToWideChar(CP_UTF8, 0, row_i, strlen(row_i), NULL, 0);
	wchar_t* wszStr = new wchar_t[len + 1];
	MultiByteToWideChar(CP_UTF8, 0, row_i, strlen(row_i), wszStr, len);
	wszStr[len] = '\0';
	return wszStr;
}
//mysql transcoding problem
char* WcharToChar(wchar_t* wp)
{
	char* m_char;
	int len = (int)WideCharToMultiByte(CP_ACP, 0, wp, (int)wcslen(wp), NULL, 0, NULL, NULL);
	m_char = new char[len + 1];
	WideCharToMultiByte(CP_ACP, 0, wp, (int)wcslen(wp), m_char, len, NULL, NULL);
	m_char[len] = '\0';
	return m_char;
}

//when data from MySQL is Chinese, it need to change from utf-8 to unicode
char* transCoding(char* c)
{
	return WcharToChar(Utf8_2_Unicode(c));
}
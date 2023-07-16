#include"infoExchangePatient.h"

//return patient's id by using case number to search
const char* caseNumberToID(const char* s)
{
	MYSQL mysql;
	MYSQL* ptr = &mysql;
	MYSQL_RES* res;
	MYSQL_ROW row;

	mysql_init(ptr);

	if (mysql_real_connect(ptr, "rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com", "try", "scut666!", "information", 3306, NULL, 0) == NULL)
	{
		std::string err = mysql_error(ptr);
		return err.data();
	}
	else
	{
		std::string option = "select * from informationofpatient where casenumber =";
		option.append(s);
		const char* op = option.data();

		if (mysql_query(ptr, op) != 0)
		{
			std::string err = mysql_error(ptr);
			return err.data();
		}
		else
		{
			res = mysql_store_result(ptr);
			row = mysql_fetch_row(res);
			//int num_fields = mysql_num_fields(res);
			if (row == nullptr)
				return "-1";
			else
				return row[0];
		}
	}
}

//return patient's case number by using id to search
const char* IDToCaseNumber(const char* s)
{
	MYSQL mysql;
	MYSQL* ptr = &mysql;
	MYSQL_RES* res;
	MYSQL_ROW row;

	mysql_init(ptr);

	if (mysql_real_connect(ptr, "rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com", "try", "scut666!", "information", 3306, NULL, 0) == NULL)
	{
		std::string err = mysql_error(ptr);
		return err.data();
	}
	else
	{
		std::string option = "select * from informationofpatient where id=";
		option.append(s);
		const char* op = option.data();

		if (mysql_query(ptr, op) != 0)
		{
			std::string err = mysql_error(ptr);
			return err.data();
		}
		else
		{
			res = mysql_store_result(ptr);
			row = mysql_fetch_row(res);
			if (row == nullptr)
				return "-1";
			else
				return row[5];
		}
	}
}


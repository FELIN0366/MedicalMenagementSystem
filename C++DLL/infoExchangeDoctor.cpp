#include"infoExchangeDoctor.h"

//return doctor's name by using id to search
const char* IDToDoctorName(const char* s)
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
		std::string option = "select * from informationofdoctor where id=";
		option.append("'");
		option.append(s);
		option.append("'");
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
				return transCoding(row[1]);
		}
	}
}
#pragma once
#include"mysql.h"
#include <string>
#include <iostream>
#include <exception>
#include"transCoding.h"

//abstract class (base class)
class basic_account	
{
protected:
	MYSQL* ptr;
	MYSQL_RES* res;
	MYSQL_ROW row;
	const char* name;
	const char* user_id;
	virtual void connectToSQL(const char* s) = 0;	//pure virtual
public:
	basic_account()
	{

	}
	basic_account(const char* s)
	{
		connectToSQL(s);
	}

	virtual ~basic_account()
	{

	}

	const char* returnName()
	{
		return name;
	}

	const char* returnID()
	{
		return user_id;
	}
};

//derived class : basic_account ---> patient
class patient : public basic_account
{
protected:
	const char* birthDate;
	const char* age;
	const char* sex;
	const char* caseNumber;
	virtual void connectToSQL(const char* s) override
	{
		//ptr points to new MYSQL object
		ptr = new MYSQL;
		mysql_init(ptr);
		mysql_real_connect(ptr, "rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com", "try", "scut666!", "information", 3306, NULL, 0);
		std::string option = "select * from informationOfPatient where id =";

		option.append(s);

		const char* op = option.data();


		int ret = mysql_query(ptr, "set names utf8");
		ret = mysql_query(ptr, op);
		//save the data to res structure,and then fetch it to row structure
		res = mysql_store_result(ptr);
		row = mysql_fetch_row(res);

		//choose the data that we need
		user_id = row[0];
		name = transCoding(row[1]);
		birthDate = row[2];
		age = row[3];
		sex = row[4];
		caseNumber = row[5];

		mysql_close(ptr);

		delete ptr;
	}
public:
	patient()
	{

	}
	patient(const char* s)
	{
		connectToSQL(s);
	}


	virtual ~patient()
	{

	}


	//return birth date
	const char* returnBirthDate()
	{
		return birthDate;
	}

	//return age
	const char* returnAge()
	{
		return age;
	}

	//return sex
	const char* returnSex()
	{
		return sex;
	}

	//return case number
	const char* returnCaseNumber()
	{
		return caseNumber;
	}
};

//derived class : basic_account ---> employee
class employee : public basic_account	//abstract class
{
protected:
	const char* employeeNumber;
};

//derived class : basic_account ---> employee ---> doctor
class doctor : public employee
{
protected:
	const char* department;
	virtual void connectToSQL(const char* s) override
	{
		//ptr points to new MYSQL object 
		ptr = new MYSQL;
		mysql_init(ptr);
		mysql_real_connect(ptr, "rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com", "try", "scut666!", "information", 3306, NULL, 0);
		std::string option = "select * from informationofdoctor where id =";
		option.append("'");
		option.append(s);
		option.append("'");	
		const char* op = option.data();

		int ret = mysql_query(ptr, "set names utf8");
		ret = mysql_query(ptr, op);
		//save the data to res structure,and then fetch it to row structure
		res = mysql_store_result(ptr);
		row = mysql_fetch_row(res);

		//choose the data that we need
		user_id = row[0];
		name = transCoding(row[1]);		//Chinese transcoding : utf-8 ---> unicode
		employeeNumber = row[2];
		department = transCoding(row[3]);	//Chinese transcoding : utf-8 ---> unicode

		mysql_close(ptr);

		delete ptr;
	}
public:
	doctor() {}
	doctor(const char* s)
	{
		connectToSQL(s);
	}
	virtual ~doctor() {}

	const char* returnEmployeeNumber()
	{
		return employeeNumber;
	}

	const char* returnDepartment()
	{
		return department;
	}

};


//derived class : basic_account ---> administrator
class administrator : public basic_account
{
protected:
	virtual void connectToSQL(const char* s) override
	{
		//ptr指向新的MYSQL对象
		ptr = new MYSQL;
		mysql_init(ptr);
		mysql_real_connect(ptr, "rm-7xv8e96z95vs8aro89o.mysql.rds.aliyuncs.com", "try", "scut666!", "information", 3306, NULL, 0);
		std::string option = "select * from informationofadministrator where id =";
		option.append("'");
		option.append(s);
		option.append("'");	
		const char* op = option.data();

		int ret = mysql_query(ptr, "set names utf8");
		ret = mysql_query(ptr, op);
		//save the data to res structure,and then fetch it to row structure
		res = mysql_store_result(ptr);
		row = mysql_fetch_row(res);

		//choose the data that we need
		user_id = row[0];
		name = transCoding(row[1]);		//Chinese transcoding : utf-8 ---> unicode

		mysql_close(ptr);

		delete ptr;
	}
public:
	administrator() {}
	administrator(const char* s) { connectToSQL(s); }
};

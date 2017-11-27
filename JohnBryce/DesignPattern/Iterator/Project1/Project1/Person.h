#pragma once
#include <string>

using namespace std;

class Person
{
public:
	Person(string strName,int nAge);
	~Person();
	const string & GetName() const;
	int GetAge() const;

private:
	string m_strName;
	int m_nAge;
};


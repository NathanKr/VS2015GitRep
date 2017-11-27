#include "Person.h"



Person::Person(string strName, int nAge) : m_strName(strName), m_nAge(nAge)
{
	
}


Person::~Person()
{
}

const string & Person::GetName() const
{
	return m_strName;
}

int Person::GetAge() const
{
	return m_nAge;
}

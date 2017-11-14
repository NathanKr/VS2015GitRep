#include "CustomString.h"
#include <string.h>

void CustomString::copy(const char * src , CustomString & target)
{
	size_t nLenChars = strlen(src) + 1;
	target.m_pText = new char[nLenChars];
	strcpy_s(target.m_pText, nLenChars * sizeof(char), src);
}

CustomString::CustomString(const char * p)
{
	copy(p, *this);
}


CustomString::~CustomString()
{
	delete[] m_pText;
	m_pText = 0;
}

const char * CustomString::GetCharPointer() const
{
	return m_pText;
}

CustomString::CustomString(const CustomString & obj)// copy constructor 
{
	copy(obj.GetCharPointer(), *this);
}

CustomString & CustomString::operator = (const CustomString & obj)// assignment operator
{
	delete[] this->m_pText;
	copy(obj.GetCharPointer(), *this);
	return *this;
}
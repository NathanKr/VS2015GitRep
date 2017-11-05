#include "Complex.h"



Complex::Complex(double fReal, double fImag)
{
	m_fImag = fImag;
	m_fReal = fReal;
}


Complex::~Complex()
{
}


ostream & operator << (ostream& os, const Complex & obj)
{
	os << "Real : " << obj.m_fReal << " , " << "Imag : " << obj.m_fImag << endl;
	return os;
}

Complex & Complex::operator +=(const Complex & c)
{
	m_fImag += c.GetImage();
	m_fReal += c.GetReal();
	return (*this);
}

double Complex::GetReal() const
{
	return m_fReal;
}

double Complex::GetImage() const
{
	return m_fImag;
}

#pragma once
#include <iostream>

using namespace std;

class Complex
{
public:
	Complex(double fReal, double fImag);
	~Complex();
	double GetReal() const;
	double GetImage() const;
	
	/*
		operator += overloading
	*/

	Complex & operator +=(const Complex & c);

	/*
	 operator << overloading

	 NOTICE << is performed on ostream e.g. cout << c1 << endl;  NOT on complex  !!!
	 so operator << does not belong to class complex
	 friend allow to access private

	 */

	friend ostream & operator <<(ostream&, const Complex & os);

private:
	double m_fReal;
	double m_fImag;
};


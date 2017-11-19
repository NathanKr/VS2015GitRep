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

	 NOTICE << is performed on ostream os e.g. cout << obj ;  NOT on complex  !!!
	 so operator << does not belong to class complex

	 NOTICE the return value is ostream & so we can do  e.g. cout << obj << endl;

	 friend allow to access private but more importantly used here to invoke << on 
	 ostream object not Complex object

	 */

	friend ostream & operator << (ostream & os, const Complex & obj);

private:
	double m_fReal;
	double m_fImag;
};


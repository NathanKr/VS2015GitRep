#include "CustomString.h"
#include <iostream>

using namespace std;

void show(const CustomString & s)
{
	const char * p = s.GetCharPointer();
	cout << p << endl;
}

void F(const CustomString & refS)
{
	CustomString s1(refS); // copy constructor used in object declaration when argument is same type
	show(s1);
}





void PassByValue(CustomString s) // copy constructor
{

}

int main()
{
	// *** constructor --> new object is created *** 
	CustomString s("123") ,s3 , s4; 


	// *** copy constructor --> new object is created from existing object*** 

	CustomString s5(s); // copy constructor is used

	CustomString s2 = s; // copy constructor used in assignment 

	PassByValue(s4); //copy constructor used in assignment of function argument

	// *** assignment constructor --> object values are assigned *** 
	s3 = s;// assignment operator is used


	show(s);


	F(s);

	show(s); // remove copy constructor to see problem


	return 0;
}
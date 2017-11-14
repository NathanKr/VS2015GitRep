#pragma once
class CustomString
{
public:
	CustomString(const char * pText = "");
	~CustomString();
	CustomString(const CustomString & obj); // copy constructor 
	CustomString & operator = (const CustomString & obj);// assignment operator
	const char * GetCharPointer() const;

private:
	char * m_pText;
	void copy(const char * src, CustomString & target);
};


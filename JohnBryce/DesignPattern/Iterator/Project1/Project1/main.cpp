#include "PersonsPtr.h"
#include <iostream>

using namespace std;

int main()
{
	Person p1("John", 23), p2("Jim", 33);
	
	PersonsPtr  objPersonsPtr;
	objPersonsPtr.PushBack(&p1);
	objPersonsPtr.PushBack(&p2);

	IIterator * p_iterator = objPersonsPtr.CreateIterator();

	while (p_iterator->HasNext())
	{
		Person * p_person = (Person *)p_iterator->Next();
		cout << p_person->GetName() << endl;
	}

	

	return 0;
}
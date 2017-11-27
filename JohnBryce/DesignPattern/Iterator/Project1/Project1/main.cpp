#include "PersonsPtr.h"
#include "IAggregate.h"
#include <iostream>

using namespace std;

// --- show generic Person * container
void Show(IAggregate * obj)
{
	IIterator * p_iterator = obj->CreateIterator();

	while (p_iterator->HasNext())
	{
		Person * p_person = (Person *)p_iterator->Next();
		cout << p_person->GetName() << endl;
	}
}

int main()
{
	Person p1("John", 23), p2("Jim", 33);
	
	PersonsPtr  objPersonsPtr;
	objPersonsPtr.PushBack(&p1);
	objPersonsPtr.PushBack(&p2);

	Show(&objPersonsPtr);


	return 0;
}
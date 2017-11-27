#pragma once
#include "Person.h"
#include "IAggregate.h"

class PersonsPtr : public IAggregate
{
	friend class PersonsPtrIterator;

public:
	PersonsPtr();
	~PersonsPtr();
	void PushBack(Person * p_person);
	IIterator * CreateIterator();


private:
	void initHead();

	typedef struct Item {
		Person * m_Person;
		Item * m_Next;
	} Item;

	Item * m_Head; // dummy has no info
	Item * m_Tail;
};


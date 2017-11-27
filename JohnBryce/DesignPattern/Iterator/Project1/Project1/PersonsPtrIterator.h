#pragma once
#include "IIterator.h"
#include "PersonsPtr.h"


class PersonsPtrIterator : public IIterator
{
public:
	PersonsPtrIterator(PersonsPtr::Item * p_head);
	~PersonsPtrIterator();
	void * Next(); // -- full abstraction using void *
	bool HasNext();

private:
	PersonsPtr::Item * m_pCurrent;
};


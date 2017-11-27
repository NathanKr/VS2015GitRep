#pragma once
#include "IIterator.h"

class IAggregate
{
public:
	virtual IIterator * CreateIterator() = 0;

};

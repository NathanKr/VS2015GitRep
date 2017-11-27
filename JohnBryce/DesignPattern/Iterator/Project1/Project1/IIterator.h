#pragma once
class IIterator
{
public:
	virtual void * Next()=0; // -- full abstraction using void *
	virtual bool HasNext()=0;
};


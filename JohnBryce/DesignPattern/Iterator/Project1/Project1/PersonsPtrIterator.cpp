#include "PersonsPtrIterator.h"



PersonsPtrIterator::PersonsPtrIterator(PersonsPtr::Item * p_head) : m_pCurrent(p_head)
{
}


PersonsPtrIterator::~PersonsPtrIterator()
{
}

void * PersonsPtrIterator::Next()
{
	m_pCurrent = m_pCurrent->m_Next;
	return m_pCurrent->m_Person;
}

bool PersonsPtrIterator::HasNext()
{
	return (m_pCurrent->m_Next != NULL);
}
#include "PersonsPtr.h"
#include "PersonsPtrIterator.h"

IIterator * PersonsPtr::CreateIterator()
{
	IIterator * p_iterator = new PersonsPtrIterator(m_Head);

	return p_iterator;
}

PersonsPtr::PersonsPtr()
{
	m_Head = new Item();
	initHead();
	m_Tail = m_Head;
}

void PersonsPtr::initHead()
{
	m_Head->m_Person = NULL;
	m_Head->m_Next = NULL;
}


PersonsPtr::~PersonsPtr()
{
	Item * p_next;
	while (m_Head != NULL)
	{
		p_next = m_Head->m_Next;
		delete m_Head; // no need to check for 0 because delete 0 is safe
		m_Head = p_next; 
	}
}

void PersonsPtr::PushBack(Person * p_person)
{
	Item * p_item = new Item();
	p_item->m_Next = NULL;
	p_item->m_Person = p_person;

	m_Tail->m_Next = p_item;
	m_Tail = p_item;
}
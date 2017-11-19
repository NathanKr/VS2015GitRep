#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
	// **** STL container
	vector<int> v; 

	v.push_back(2);
	v.push_back(0);
	v.push_back(3);
	v.push_back(12);

	// --- iteate using index
	for (size_t i = 0; i < v.size(); i++)
	{
		cout << v[i] << endl;
	}

	cout << endl;

	// **** STL algorithm
	sort(v.begin(),v.end());

	// **** STL iterator : abstraction of pointer but has no null
	vector<int>::iterator it_vec; 
	for (it_vec = v.begin() ; it_vec != v.end() ; it_vec++)
	{
		cout << *it_vec << endl;
	}


	return 0;
}
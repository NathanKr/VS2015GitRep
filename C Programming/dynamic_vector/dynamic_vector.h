#include <stdlib.h>

typedef enum dv_status_code
{
	dv_success=0,
	dv_failure=1
} dv_status_code;

typedef struct dynamic_vector
{
	void* array;
	size_t size_of_element;
	size_t num_of_elements;	
	size_t capacity;		// max num elements 
} dynamic_vector_t ;

dynamic_vector_t *DVCreate(size_t num_elements , size_t element_size);
void DVDestroy(dynamic_vector_t* dv);
void* DVItemAddress(dynamic_vector_t* dv,size_t idx );
int DVPushBack( dynamic_vector_t *dv , const void* data); /* returns 1 on allocation failure */
void DVPopBack(dynamic_vector_t *dv);
size_t DVSize( const dynamic_vector_t *dv );
size_t DVCapacity(const dynamic_vector_t *dv );
int DVReserve(dynamic_vector_t *dv, size_t new_capacity); /* returns 1 on allocation failure */
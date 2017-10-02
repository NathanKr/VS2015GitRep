#include "dynamic_vector.h"
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>
#include <stdio.h>

#define SHRINK_FACTOR  4

void debugPrint(dynamic_vector_t * dv)
{
    printf("num_of_elements : %d\n",dv->num_of_elements);
    printf("capacity : %d\n",dv->capacity);
    printf("size_of_element : %d\n",dv->size_of_element);
    for(int i=0; i< dv->num_of_elements; i++)
    {
        printf("%x\n",dv->array+(i*dv->size_of_element));
    }
    printf("\n");
}

dv_status_code shrinkCapacityIfNeeded(dynamic_vector_t *dv)
{
    dv_status_code status = dv_success;
    int reducedCapacity = dv->capacity/SHRINK_FACTOR;
    if(dv->num_of_elements <= reducedCapacity)
    {
        /* may fail if memory was taken after we have free it ? 
        need to check if realloc is atomic */
        status = DVReserve(dv,reducedCapacity);
    }

    return status;
}

bool enoughCapacityToAddOneItem(dynamic_vector_t * dv)
{
    return (dv->num_of_elements < dv->capacity);
}

size_t DVSize( const dynamic_vector_t *dv )
{
    return dv->num_of_elements;
}

void DVPopBack(dynamic_vector_t *dv)
{
    if(dv->num_of_elements> 0)
    {
        dv->num_of_elements--;
        shrinkCapacityIfNeeded(dv);
    }
}



size_t DVCapacity(const dynamic_vector_t *dv )
{
    return dv->capacity;
}

/* returns 1 on allocation failure */
int DVReserve(dynamic_vector_t *dv, size_t new_capacity)
{
    dv_status_code status = dv_failure;
    void * ptr = realloc(   dv->array , 
                            new_capacity*dv->size_of_element);
    if(ptr)
    {
        status = dv_success;
        dv->array = ptr;
        dv->capacity = new_capacity;
    }    

    return status;
}


dv_status_code doubleCapacity(dynamic_vector_t * dv)
{
    return DVReserve(dv,dv->capacity*2);
}

dynamic_vector_t *DVCreate(size_t num_elements , size_t element_size)
{
    dynamic_vector_t * dv = malloc(sizeof(dynamic_vector_t));

    if(dv)
    {
        dv->capacity = num_elements;
        dv->num_of_elements = 0;//because nothing is pushed yet
        dv->size_of_element  = element_size;
        dv->array = malloc(num_elements*element_size);
    }

    return dv;
}

void DVDestroy(dynamic_vector_t * dv)
{
    if(dv)
    {
        free(dv->array);
        free(dv);
    }
}

/* returns 1 on allocation failure */
int DVPushBack( dynamic_vector_t *dv , const void* data)
{
    int indexFirstFree;

    //debugPrint(dv);

    if(!enoughCapacityToAddOneItem(dv))
    {
        if(doubleCapacity(dv) == dv_failure)
        {
            return dv_failure;
        }
    }
    
    indexFirstFree = dv->num_of_elements;
    memcpy( dv->array+indexFirstFree*dv->size_of_element,
            data, 
            dv->size_of_element);

    dv->num_of_elements++;

    //debugPrint(dv);
    
    return dv_success;
}

void* DVItemAddress(dynamic_vector_t* dv,size_t idx )
{
    return dv->array+idx*dv->size_of_element;
}
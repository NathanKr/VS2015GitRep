#include <stdio.h>
#include "dynamic_vector.h"
#include <stdbool.h>


// some comment added 6/12/2017

int * initIntArray(int nArraySize)
{
    int * ar = malloc(nArraySize*sizeof(int));

    for(int i=0; i<nArraySize; i++)
    {
        ar[i]=i;
    }     
    return ar;
}


int main()
{
    dynamic_vector_t * dv ;
    int * p_int , * ar;
    int nArrayLength = 8,nInitialCapacity;
    bool bCapacityWasReduced=false;

    ar = initIntArray(nArrayLength);

    size_t  num_elements=3 ,
            element_size=sizeof(int *);//bytes

    dv = DVCreate(num_elements ,element_size);
    if(!dv)
    {
        printf("error : create");
        return 1;
    }

    // --- push back
    for(int i=0; i <nArrayLength; i++)
    {
        if( DVPushBack( dv , &ar[i]) == 1)
        {
            printf("error : push back");
            return 1;
        }

        p_int = DVItemAddress(dv,i);
        if(*p_int != ar[i])
        {
            printf("error : push \\ get");
            return 1;
        }
    }     
    
    // --- pop back
    nInitialCapacity = DVCapacity(dv);
    for(int i=0; i <nArrayLength; i++)
    {
        DVPopBack(dv);
        if(DVSize(dv) != (nArrayLength-1-i))
        {
            printf("error : popback");
            return 1;
        }
        bCapacityWasReduced = DVCapacity(dv) < nInitialCapacity;
    }

    if(!bCapacityWasReduced)
    {
        printf( "error : expecting reduced capacity for initial capacity %d",
                nInitialCapacity);
        return 1;
    }

    DVDestroy(dv);

    puts("success : hit key for finish");
    getchar();
    return 0;
}
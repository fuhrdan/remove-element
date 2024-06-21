//*****************************************************************************
//** 27. Remove Element leetcode                                             **
//** I went with a simple loop, find the element, then use another loop to   **
//** remove the element.  I added a switch to have it repeat the same element**
//** Int the loop and count down how many elements were removed.  --Dan      **
//*****************************************************************************

int removeElement(int* nums, int numsSize, int val) {
    int retNum = numsSize;
    int subtract = 0;
//    printf("numsSize = %d\n",numsSize);
    for(int i = 0; i < numsSize; i++)
    {
        if(subtract == 1)
        {
            i--;
        }
        subtract = 0;
//        printf("numsSize = %d nums[%d] = %d\n",numsSize,i,nums[i]);
        if(nums[i] == val)
        {
//            printf("VAL! i = %d\n",i);
            for(int j = i; j < numsSize; j++)
            {
                if(j < numsSize - 1)
                {
                    nums[j] = nums[j+1];
                }
                if(j == numsSize - 1)
                {
                    nums[j] = 200;
                }
            }
            retNum--;
            subtract = 1;
        }
//        printf("numsSize = %d nums[%d] = %d\n",numsSize,i,nums[i]);

    }
//    for(int l = 0; l < numsSize; l++)
//    {
//        printf("retnum = %d nums[%d] = %d\n",retNum,l,nums[l]);
//    }
    return retNum;    
}
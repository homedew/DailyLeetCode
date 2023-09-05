// You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.

// Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

 

// Example 1:

// Input: flowerbed = [1,0,0,0,1], n = 1
// Output: true
// Example 2:

// Input: flowerbed = [1,0,0,0,1], n = 2
// Output: false

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int i = 0;
        if(n==0) return true;

        while(i < flowerbed.Length)
        {
            if(flowerbed[i] == 0)
            {
                bool leftCanPlant = (i == 0)  || (flowerbed[i - 1] == 0);

                if(i ==  flowerbed.Length) break;
                bool rightCanPlant = (i == flowerbed.Length - 1)  || (flowerbed[i + 1] == 0);


                if(leftCanPlant  && rightCanPlant)
                {
                    n--;
                    flowerbed[i] = 1;
                    if(n == 0)
                    {
                        return true;
                    }

                    i += 2;
                } else {
                    i++;
                }

            } else {
                i++;
            }

        }

        return false;
    }
}
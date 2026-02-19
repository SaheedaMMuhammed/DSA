public class Solution {
    public bool IsPalindrome(int x) {
        int reverse=0;
        if(x<0){
            return false;
        }

        else
        {
         reverse=reverseNum(x);
        }
        if(reverse==x){
            return true;
        }
        return false;
    }

    public int reverseNum(int x)
    {
        int reversed=0;
        while(x>0)
        {
            reversed=(reversed*10)+(x%10);
            x/=10;
        }
        return reversed;
    }
}
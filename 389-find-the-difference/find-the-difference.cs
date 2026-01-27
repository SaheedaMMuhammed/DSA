public class Solution {
    public char FindTheDifference(string s, string t) 
    {
        if(s.Length==0){
            return t[0];
        }
        int sumS=0;                             //all char have their corresponding 
                                                //integer code so difference of their sum
                                                //of code will be the code of the added
                                                //character
        int sumT=0;
        for(int i=0;i<s.Length;i++)
        {
            sumS+=(int)s[i];
        }
        for(int i=0;i<t.Length;i++)
        {
            sumT+=(int)t[i];
        }

        int difference=sumT-sumS;
        return (char)difference;
    }
}
public class Solution {
    public char FindTheDifference(string s, string t) 
    {
        
        if(s.Length==0)
        {
                return t[0];
        }
        int sumS=0;
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
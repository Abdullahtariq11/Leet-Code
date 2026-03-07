class Solution {
    public int balancedStringSplit(String s) {
        int lCount=0;
        int rCount=0;
        int maxStrings=0;
        for(char c:s.toCharArray()){
            if(c=='L'){
                lCount++;
            }
            else{
                rCount++;
            }
            if(lCount==rCount){
                maxStrings++;
                lCount=0;
                rCount=0;
            }
        }
        return maxStrings;
    }
}
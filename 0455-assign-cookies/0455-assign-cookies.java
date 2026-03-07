class Solution {
    public int findContentChildren(int[] g, int[] s) {
        Arrays.sort(g);
        Arrays.sort(s);
        int cookieIndex=0;
        int childIndex=0;
        while(childIndex<g.length && cookieIndex<s.length){
            if(s[cookieIndex]>=g[childIndex]){
                childIndex++;       
            }
            cookieIndex++;
        }
        return childIndex;
    }
}
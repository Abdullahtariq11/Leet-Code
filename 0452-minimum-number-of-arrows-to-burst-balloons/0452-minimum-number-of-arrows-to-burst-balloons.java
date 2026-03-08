class Solution {
    public int findMinArrowShots(int[][] points) {
        //lets sort by end time;
        Arrays.sort(points,(a,b)->Integer.compare(a[1],b[1]));
        int arrowCounts=1;
        int baloonCount=0;
        int currentRangeEnd=points[0][1];
        for(int i=1;i<points.length;i++){
            if(points[i][0]<=currentRangeEnd){
                baloonCount++;
            }
            else{
                arrowCounts++;
                currentRangeEnd=points[i][1];
            }
        }
        return arrowCounts;
  
    }
}
class Solution {
    public int findMinArrowShots(int[][] points) {
        if (points == null || points.length == 0) 
        {
            return 0;
        }

        Arrays.sort(points, (a, b) -> {
            if (a[0] != b[0]){
                return Integer.compare(a[0], b[0]);
            } 
            return Integer.compare(a[1], b[1]);
        });

        int arrowCount = 1;
        long currentEnd = points[0][1];

        for (int i = 1; i < points.length; i++) {
            long start = points[i][0];
            long end = points[i][1];

            if (start <= currentEnd) {
                currentEnd = Math.min(currentEnd, end);
            } else {
                arrowCount++;
                currentEnd = end;
            }
        }

        return arrowCount;
    }
}
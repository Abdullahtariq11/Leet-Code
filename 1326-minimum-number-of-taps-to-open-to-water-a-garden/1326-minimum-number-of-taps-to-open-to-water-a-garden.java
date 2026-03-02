class Solution {
    public int minTaps(int n, int[] ranges) {
        int[] maxReachFromLeft = new int[n + 1];

        for (int i = 0; i <= n; i++) {
            int left = Math.max(0, i - ranges[i]);
            int right = Math.min(n, i + ranges[i]);
            maxReachFromLeft[left] = Math.max(maxReachFromLeft[left], right);
        }

        int taps = 0;
        int currEnd = 0;  
        int farthest = 0;  

        for (int i = 0; i <= n; i++) {
            farthest = Math.max(farthest, maxReachFromLeft[i]);

            if (i == currEnd) {
                if (currEnd >= n) return taps;

                if (farthest == currEnd) return -1;

                taps++;
                currEnd = farthest;
            }
        }

        return currEnd >= n ? taps : -1;
    }
}
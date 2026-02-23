class Solution {
    public int maxSubArray(int[] nums) {
        int n = nums.length-1;
        int currentSum=nums[0];
        int maxSum=nums[0];
        if(n<1){
            return maxSum;
        }
        for (int i=1; i<= n ; i++){
            currentSum= Math.max(currentSum + nums[i],nums[i]);
            if(currentSum > maxSum){
                maxSum=currentSum;
            }
        }
        return maxSum;
    }
}
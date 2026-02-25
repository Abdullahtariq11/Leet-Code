class Solution {
    public List<List<Integer>> combinationSum(int[] nums, int target) {
        List<List<Integer>> combinationSets= new ArrayList();
        List<Integer> currentSet= new ArrayList();
        int start=0;
        backtrack(nums,target,combinationSets,currentSet,start);

       return  combinationSets;   
    }

    public void backtrack(int[] nums, int target,List<List<Integer>> combinationSets,List<Integer> currentSet,int start){
        int sum=0;
        for(int value:currentSet){
            sum += value;
        }
        if(sum == target){
            combinationSets.add(new ArrayList(currentSet));
            return;
        }
        if(sum > target){
            return;
        }
        for(int i=start;i<nums.length;i++){
            currentSet.add(nums[i]);
            backtrack(nums,target,combinationSets,currentSet,i);
            currentSet.remove(currentSet.size()-1);
        }
    }
}

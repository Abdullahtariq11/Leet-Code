class Solution {
    public List<List<Integer>> subsets(int[] nums) {
        int start =0;
        List<List<Integer>> subsetList= new ArrayList();
        List<Integer> currentList= new ArrayList();

        backtrack(nums,start,subsetList,currentList);

        return subsetList;

    }
    public void backtrack(int[] nums, int start, List<List<Integer>> subsetList, List<Integer> currentList){
        subsetList.add(new ArrayList(currentList));

        for(int i=start;i<nums.length;i++){
            currentList.add(nums[i]);
            backtrack(nums,i+1,subsetList,currentList);
            currentList.remove(currentList.size()-1);
        }
    }
}
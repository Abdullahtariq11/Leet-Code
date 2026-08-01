class Solution {
    public List<Integer> findDuplicates(int[] nums) {
        HashMap<Integer,Boolean> map= new HashMap<>();
        List<Integer> list= new ArrayList<>();


        for(int num: nums){
            if(map.containsKey(num)){
                map.put(num,false);
                list.add(num);
            }
            else{
                map.put(num,true);
            }
        }
        return list;
    }
}
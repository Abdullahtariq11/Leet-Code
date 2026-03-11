class Solution {
    public boolean canFinish(int numCourses, int[][] prerequisites) {
        ArrayList<ArrayList<Integer>> courseGraph = new ArrayList<>();
        for (int i = 0; i < numCourses; i++) {
            courseGraph.add(new ArrayList<>());
        }
        for (int i = 0; i < prerequisites.length; i++) {
            int course = prerequisites[i][0];
            int prerequisite = prerequisites[i][1];
            
            // b -> a (To take 'a', you must finish 'b' first)
            courseGraph.get(prerequisite).add(course);
        }
        int [] isVisited= new int [numCourses];
        for(int i=0;i<=numCourses-1;i++){
            if(isVisited[i]==0){
                if(DfsCycle(i,courseGraph,isVisited)){
                    return false;
                }
            }
        }
        return true;
    }

    private boolean DfsCycle(int i, ArrayList<ArrayList<Integer>> courseGraph,int [] isVisited){
            isVisited[i]=1;

        for(int c : courseGraph.get(i)){
            if (isVisited[c] == 1) {
                return true; 
            }
            if (isVisited[c] == 0 && DfsCycle(c, courseGraph, isVisited)) {
                return true;
            }
        
        }
        isVisited[i] = 2; 
        return false;

    }
}

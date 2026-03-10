class Solution {
    public int maxAreaOfIsland(int[][] grid) {
        int m=grid.length;
        int n=grid[0].length;
        Queue<Points> q=new LinkedList<>();
        boolean [][] isVisited=new boolean [m][n];
        int[][] directions = {{-1, 0}, {0, -1}, {1, 0}, {0, 1}};
        int maxArea=0;


        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(grid[i][j]==1 && !isVisited[i][j]){
                    int currentArea=0;
                    q.add(new Points(i,j));
                    isVisited[i][j]=true;

                    while(!q.isEmpty()){
                        Points curr= q.poll();
                        currentArea++;
                        for (int[] d : directions)
                        {
                            int nextX = curr.x + d[0];
                            int nextY = curr.y + d[1];

                            if (nextX >= 0 && nextX < m && nextY >= 0 && nextY < n 
                            && grid[nextX][nextY] == 1 && !isVisited[nextX][nextY]) 
                            {
                                isVisited[nextX][nextY]=true;
                                q.add(new Points(nextX, nextY)); 
                            }
                        }
                        maxArea=Math.max(currentArea,maxArea);
                    }

                }
            }
        }
        return maxArea;
        
    }
    public class Points{
        int x;
        int y;
        public Points(int x,int y){
            this.x=x;
            this.y=y;
        }
    }
}
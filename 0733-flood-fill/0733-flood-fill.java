import java.util.*;

class Solution {
    public int[][] floodFill(int[][] image, int sr, int sc, int color) {
        int originalColor = image[sr][sc];
        
        if (originalColor == color) return image;
        
        int m = image.length;
        int n = image[0].length;
        int[][] directions = {{-1, 0}, {0, -1}, {1, 0}, {0, 1}};
        
        Queue<Point> q = new LinkedList<>();
        

        q.add(new Point(sr, sc));
        image[sr][sc] = color; 
        
        while (!q.isEmpty()) {
            Point curr = q.poll();

            for (int[] d : directions) {
                int nextX = curr.x + d[0];
                int nextY = curr.y + d[1];

                if (nextX >= 0 && nextX < m && nextY >= 0 && nextY < n 
                    && image[nextX][nextY] == originalColor) {
                    
                    image[nextX][nextY] = color;
                    q.add(new Point(nextX, nextY)); 
                }
            }
        }
        
        return image;
    }
    
    public class Point {
        int x, y;
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTest._Not_Complete_Problems
{
    internal class Problem_0733
    {
        public class Solution
        {
            public int[][] FloodFill(int[][] image, int sr, int sc, int color)
            {
                if (image[sr][sc] == color) return image;
                //
                var baseColor = image[sr][sc];
                //
                image[sr][sc] = color;
                //
                if (sr - 1 >= 0 && image[sr - 1][sc] == baseColor)
                {
                    image = FloodFill(image, sr - 1, sc, color);
                    
                }
                if (sr + 1 < image.Length && image[sr + 1][sc] == baseColor)
                {
                    image = FloodFill(image, sr + 1, sc, color);
                    
                }
                if (sc - 1 >= 0 && image[sr][sc - 1] == baseColor) 
                {
                    image = FloodFill(image, sr, sc - 1, color);
                    
                }
                if (sc + 1 < image[0].Length && image[sr][sc + 1] == baseColor) 
                {
                    image = FloodFill(image, sr, sc + 1, color);

                }
                
                return image;
            }

            //int[][] Fill(int[][] image, int )
        }
    }
}

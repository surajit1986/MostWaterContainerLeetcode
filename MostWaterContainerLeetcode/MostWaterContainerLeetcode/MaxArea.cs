using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MostWaterProblem
{
    public class MaxArea
    {
        public int GetMaxArea(int[] heights)
        {
            int maxArea = 0;
            int height = 0;
            int length = 0;
            int area = 0;

            for(int i =0; i < heights.Length; i++)
            {
                for(int j =i+1;j<heights.Length; j++)
                {
                    height = Math.Min(heights[i], heights[j]);
                    length = j-i;
                    area = height * length;
                    maxArea = Math.Max(maxArea, area);
                }
            }

            return maxArea;
        }

        //Optimized Solution :
        public int GetMaxAreaOptimized(int[] heights)
        {
            int maxArea = 0;
            int start = 0;
            int end = heights.Length-1;
            int area = 0;
            int height = 0;
            int width = 0;

            while(start < end)
            {
                height = Math.Min(heights[start], heights[end]);
                width = end - start;
                area = height * width;
                maxArea = Math.Max(area, maxArea);

                if (heights[start] < heights[end])
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            return maxArea;
        }
    }
}

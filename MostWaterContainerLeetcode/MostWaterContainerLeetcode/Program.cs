// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information


//You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and(i, height[i]).

//Find two lines that together with the x-axis form a container, such that the container contains the most water.

//Return the maximum amount of water a container can store.

//Notice that you may not slant the container.

//using static System.Collections.Specialized.BitVector32;

//Input: height = [1, 8, 6, 2, 5, 4, 8, 3, 7]
//Output: 49
//Explanation: The above vertical lines are represented by array [1, 8, 6, 2, 5, 4, 8, 3, 7].In this case, the max area of water(blue section) the container can contain is 49.
//Example 2:

//Input: height = [1, 1]
//Output: 1


using MostWaterProblem;

int[] heights = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
MaxArea area = new MaxArea();
Console.WriteLine($"maximum area water can contain:{area.GetMaxArea(heights)}");
Console.WriteLine($"maximum area water can contain(optimized):{area.GetMaxAreaOptimized(heights)}");
Console.ReadKey();

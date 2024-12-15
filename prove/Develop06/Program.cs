// For my creative component, I added to gamification by creating a way for 
// the user to level up every time their score reached another 200 points from 
// Sunbeam to Master Goal Keeper. A congratulations banner gets displayed when each 
// level is passed.   

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}
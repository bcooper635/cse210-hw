using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goal1 = new();
        goal1.Start();
        //Showed creativity by gamification for the score system. For every 100 points the user gets a new rank.
        //the ranks go from <100 to >1000, and include:
        // Rank: Novice Adventurer
        // Rank: Apprentice Scribe
        // Rank: Journeyman Tracker
        // Rank: Skilled Chronicler
        // Rank: Veteran Pathfinder
        // Rank: Expert Historian
        // Rank: Master Archivist
        // Rank: Epic Lorekeeper
        // Rank: Legendary Quest Recorder
        // Rank: Mythic Grandmaster
        // Rank: Eternal Legend
    }
}
﻿using System;

namespace Test_Rogue
{
    class ReallyReallyReallySimpleRogueLike
    {
        static void Main(string[] args)
        {
            Dungeon dungeon = new Dungeon(Constants.DungeonWidth, Constants.DungeonHeight);
            string displayText = Constants.IntroductionText;
            while (dungeon.IsGameActive)
            {
                dungeon.DrawToConsole();
                Console.WriteLine(displayText);
                Console.Write(Constants.CursorImage);
                displayText = dungeon.ExecuteCommand(Console.ReadKey());
            }

            Console.WriteLine(ConcludeGame(dungeon));
            Console.ReadLine();
        }

        private static string ConcludeGame(Dungeon dungeon)
        {
            return (dungeon.player.Hits > 0) ? Constants.PlayerWinsText : Constants.MonsterWinsText;
        }
    }
}

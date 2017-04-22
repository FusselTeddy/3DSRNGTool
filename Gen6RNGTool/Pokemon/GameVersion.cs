﻿namespace Gen6RNGTool
{
    public enum GameVersion
    {
        // Not actually stored values, but assigned as properties.
        Any = -1,

        // Version IDs, also stored in PKM structure
        /*Gen6*/
        X = 24, Y = 25, AS = 26, OR = 27,

        // Game Groupings (SaveFile type)
        XY = 106,
        ORAS = 108,
    }

    public static class Extension
    {
        public static bool Contains(this GameVersion g1, GameVersion g2)
        {
            if (g1 == g2 || g1 == GameVersion.Any)
                return true;

            switch (g1)
            {
                case GameVersion.XY: return g2 == GameVersion.X || g2 == GameVersion.Y;
                case GameVersion.ORAS: return g2 == GameVersion.OR || g2 == GameVersion.AS;
                default: return false;
            }
        }
    }
}

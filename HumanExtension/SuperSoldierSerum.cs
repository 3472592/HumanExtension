namespace HumanExtension
{
    public static class SuperSoldierSerum
    {
        public static string BreakWalls(this OrdinaryHuman h, double wallDensity)
        {
            if (h is null)
                throw new ArgumentNullException(nameof(h));

            return ("I broke through a wall of " + wallDensity + " density");
        }
    }
}

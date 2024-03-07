namespace OneHundredDoors;

public static class Doors
{
    public static bool Toggle(bool door) => !door;

    public static bool ShouldToggle(int index, int iteration) => (index + 1) % iteration == 0;

    public static Func<bool, int, bool> ConditionalToggle(int iteration) =>
        (door, index) => ShouldToggle(index, iteration) ? Toggle(door) : door;

    public static bool[] Pass(bool[] doors, int iteration) =>
        doors.Select(ConditionalToggle(iteration)).ToArray();

    public static bool[] Iterate(bool[] doors, int iterations) =>
        Enumerable.Range(1, iterations).Aggregate(doors, Pass);

    public static bool[] Solution() => Iterate(new bool[100], 100);
}
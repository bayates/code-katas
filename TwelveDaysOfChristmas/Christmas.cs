namespace TwelveDaysOfChristmas;

public static class Christmas
{
    private static readonly string[] Ordinals =
    [
        "first",
        "second",
        "third",
        "fourth",
        "fifth",
        "sixth",
        "seventh",
        "eighth",
        "ninth",
        "tenth",
        "eleventh",
        "twelfth"
    ];

    private static readonly string[] VerseBodyLines =
    [
        "A partridge in a pear tree.",
        "Two turtle doves and",
        "Three french hens",
        "Four calling birds",
        "Five golden rings",
        "Six geese a-laying",
        "Seven swans a-swimming",
        "Eight maids a-milking",
        "Nine ladies dancing",
        "Ten lords a-leaping",
        "Eleven pipers piping",
        "Twelve drummers drumming"
    ];

    public static string VerseHeader(int verse) =>
        $"On the {Ordinals[verse - 1]} day of Christmas\n" +
        "My true love gave to me:";

    public static string VerseBody(int verse) =>
        string.Join("\n", VerseBodyLines.Take(verse).Reverse());

    public static string Verse(int verse) =>
        VerseHeader(verse) + "\n" + VerseBody(verse);

    public static string Song() =>
        string.Join("\n\n", Enumerable.Range(1, 12).Select(Verse));
}

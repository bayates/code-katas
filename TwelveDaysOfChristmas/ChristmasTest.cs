using NUnit.Framework;

namespace TwelveDaysOfChristmas;

[TestFixture]
public class ChristmasTest
{
    [TestCase(1, "On the first day of Christmas\nMy true love gave to me:")]
    [TestCase(2, "On the second day of Christmas\nMy true love gave to me:")]
    [TestCase(3, "On the third day of Christmas\nMy true love gave to me:")]
    [TestCase(4, "On the fourth day of Christmas\nMy true love gave to me:")]
    [TestCase(5, "On the fifth day of Christmas\nMy true love gave to me:")]
    [TestCase(5, "On the fifth day of Christmas\nMy true love gave to me:")]
    [TestCase(6, "On the sixth day of Christmas\nMy true love gave to me:")]
    [TestCase(7, "On the seventh day of Christmas\nMy true love gave to me:")]
    [TestCase(8, "On the eighth day of Christmas\nMy true love gave to me:")]
    [TestCase(9, "On the ninth day of Christmas\nMy true love gave to me:")]
    [TestCase(10, "On the tenth day of Christmas\nMy true love gave to me:")]
    [TestCase(11, "On the eleventh day of Christmas\nMy true love gave to me:")]
    [TestCase(12, "On the twelfth day of Christmas\nMy true love gave to me:")]
    public void VerseHeader(int verse, string expected)
    {
        Assert.That(Christmas.VerseHeader(verse), Is.EqualTo(expected));
    }

    [TestCase(1, "A partridge in a pear tree.")]
    [TestCase(2, "Two turtle doves and\nA partridge in a pear tree.")]
    [TestCase(12, @"Twelve drummers drumming
Eleven pipers piping
Ten lords a-leaping
Nine ladies dancing
Eight maids a-milking
Seven swans a-swimming
Six geese a-laying
Five golden rings
Four calling birds
Three french hens
Two turtle doves and
A partridge in a pear tree.")]
    public void VerseBody(int verse, string expected)
    {
        Assert.That(Christmas.VerseBody(verse), Is.EquivalentTo(expected));
    }

    [TestCase(1, @"On the first day of Christmas
My true love gave to me:
A partridge in a pear tree.")]
    [TestCase(2, @"On the second day of Christmas
My true love gave to me:
Two turtle doves and
A partridge in a pear tree.")]
    [TestCase(12, @"On the twelfth day of Christmas
My true love gave to me:
Twelve drummers drumming
Eleven pipers piping
Ten lords a-leaping
Nine ladies dancing
Eight maids a-milking
Seven swans a-swimming
Six geese a-laying
Five golden rings
Four calling birds
Three french hens
Two turtle doves and
A partridge in a pear tree.")]
    public void Verse(int verse, string expected)
    {
        Assert.That(Christmas.Verse(verse), Is.EqualTo(expected));
    }

    [Test]
    public void Song()
    {
        Assert.That(Christmas.Song(), Is.EqualTo(_lyrics));
    }

    private readonly string _lyrics =
@"On the first day of Christmas
My true love gave to me:
A partridge in a pear tree.

On the second day of Christmas
My true love gave to me:
Two turtle doves and
A partridge in a pear tree.

On the third day of Christmas
My true love gave to me:
Three french hens
Two turtle doves and
A partridge in a pear tree.

On the fourth day of Christmas
My true love gave to me:
Four calling birds
Three french hens
Two turtle doves and
A partridge in a pear tree.

On the fifth day of Christmas
My true love gave to me:
Five golden rings
Four calling birds
Three french hens
Two turtle doves and
A partridge in a pear tree.

On the sixth day of Christmas
My true love gave to me:
Six geese a-laying
Five golden rings
Four calling birds
Three french hens
Two turtle doves and
A partridge in a pear tree.

On the seventh day of Christmas
My true love gave to me:
Seven swans a-swimming
Six geese a-laying
Five golden rings
Four calling birds
Three french hens
Two turtle doves and
A partridge in a pear tree.

On the eighth day of Christmas
My true love gave to me:
Eight maids a-milking
Seven swans a-swimming
Six geese a-laying
Five golden rings
Four calling birds
Three french hens
Two turtle doves and
A partridge in a pear tree.

On the ninth day of Christmas
My true love gave to me:
Nine ladies dancing
Eight maids a-milking
Seven swans a-swimming
Six geese a-laying
Five golden rings
Four calling birds
Three french hens
Two turtle doves and
A partridge in a pear tree.

On the tenth day of Christmas
My true love gave to me:
Ten lords a-leaping
Nine ladies dancing
Eight maids a-milking
Seven swans a-swimming
Six geese a-laying
Five golden rings
Four calling birds
Three french hens
Two turtle doves and
A partridge in a pear tree.

On the eleventh day of Christmas
My true love gave to me:
Eleven pipers piping
Ten lords a-leaping
Nine ladies dancing
Eight maids a-milking
Seven swans a-swimming
Six geese a-laying
Five golden rings
Four calling birds
Three french hens
Two turtle doves and
A partridge in a pear tree.

On the twelfth day of Christmas
My true love gave to me:
Twelve drummers drumming
Eleven pipers piping
Ten lords a-leaping
Nine ladies dancing
Eight maids a-milking
Seven swans a-swimming
Six geese a-laying
Five golden rings
Four calling birds
Three french hens
Two turtle doves and
A partridge in a pear tree.";
}

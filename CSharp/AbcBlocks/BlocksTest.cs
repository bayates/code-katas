using NUnit.Framework;

namespace Abc;

[TestFixture]
public class BlocksTest
{
    [Test]
    public void ToString_Debug()
    {
        var block = new Block('B','O');
        Assert.That(block.ToString(), Is.EqualTo("Block { Letters = ['B','O'] }"));
    }
    
    [Test]
    public void FindBlock_FirstBlock_FirstLetter()
    {
        var blocks = new[]
        {
            new Block('A','B'),
            new Block('C','D')
        };
        
        Assert.That(Blocks.FindBlock(blocks, 'A'), Is.SameAs(blocks[0]));
    }
    
    [Test]
    public void FindBlock_SecondBlock_FirstLetter()
    {
        var blocks = new[]
        {
            new Block('A','B'),
            new Block('C','D')
        };
        
        Assert.That(Blocks.FindBlock(blocks, 'C'), Is.SameAs(blocks[1]));
    }
    
    [Test]
    public void FindBlock_FirstBlock_SecondLetter()
    {
        var blocks = new[]
        {
            new Block('A','B'),
            new Block('C','D')
        };
        
        Assert.That(Blocks.FindBlock(blocks, 'B'), Is.SameAs(blocks[0]));
    }
    
    [Test]
    public void FindBlock_NotFound()
    {
        var blocks = new[]
        {
            new Block('A','B'),
            new Block('C','D')
        };
        
        Assert.That(Blocks.FindBlock(blocks, '!'), Is.Null);
    }
    
    [TestCase("A", true)]
    [TestCase("!", false)]
    [TestCase("a", true)]
    [TestCase("ZZ", false)]
    [TestCase("BARK", true)]
    [TestCase("BOOK", false)]
    [TestCase("TREAT", true)]
    [TestCase("COMMON", false)]
    [TestCase("SQUAD", true)]
    [TestCase("CONFUSE", true)]
    public void CanSpell(string word, bool expected)
    {
        var blocks = new[]
        {
            new Block('B','O'),
            new Block('X','K'),
            new Block('D','Q'),
            new Block('C','P'),
            new Block('N','A'),
            new Block('G','T'),
            new Block('R','E'),
            new Block('T','G'),
            new Block('Q','D'),
            new Block('F','S'),
            new Block('J','W'),
            new Block('H','U'),
            new Block('V','I'),
            new Block('A','N'),
            new Block('O','B'),
            new Block('E','R'),
            new Block('F','S'),
            new Block('L','Y'),
            new Block('P','C'),
            new Block('Z','M')
        };
        
        Assert.That(Blocks.CanSpell(blocks, word), Is.EqualTo(expected));
    }
}

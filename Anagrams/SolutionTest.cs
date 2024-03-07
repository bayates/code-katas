using NUnit.Framework;

namespace Anagrams;

[TestFixture]
public class SolutionTest
{
    [Test]
    public void GetAnagrams_EmptyString()
    {
        Assert.That(
            Solution.GetAnagrams(""),
            Is.EquivalentTo(Enumerable.Empty<string>()));
    }
    
    [Test]
    public void GetAnagrams_SingleCharacter()
    {
        Assert.That(
            Solution.GetAnagrams("a"),
            Is.EquivalentTo(new[] { "a" }));
    }
    
    [Test]
    public void GetAnagrams_TwoCharacters()
    {
        Assert.That(
            Solution.GetAnagrams("ab"),
            Is.EquivalentTo(new[] { "ab", "ba" }));
    }
    
    [Test]
    public void GetAnagrams_RepeatedCharacter()
    {
        Assert.That(
            Solution.GetAnagrams("aa"),
            Is.EquivalentTo(new[] { "aa" }));
    }
    
    [Test]
    public void GetAnagrams_FourCharacters()
    {
        Assert.That(
            Solution.GetAnagrams("biro"),
            Is.EquivalentTo(new[]
            {
                "biro", "bior", "brio", "broi", "boir", "bori",
                "ibro", "ibor", "irbo", "irob", "iobr", "iorb",
                "rbio", "rboi", "ribo", "riob", "roib", "robi",
                "obir", "obri", "oibr", "oirb", "orbi", "orib"
            }));
    }
    
    [Test]
    public void GetCombinations()
    {
        Assert.That(
            Solution.GetCombinations('a', "bc"),
            Is.EquivalentTo(new[] { "abc", "bac", "bca" }));
    }
}

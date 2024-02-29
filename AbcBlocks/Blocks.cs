namespace Abc;

public class Blocks
{    
    public static bool CanSpell(IEnumerable<Block> blocks, string word)
    {
        var availableBlocks = new HashSet<Block>(blocks);
        
        foreach (var letter in word)
        {
            var block = FindBlock(availableBlocks, letter);
            
            if (block == null)
                return false;
            
            availableBlocks.Remove(block);
        }
        
        return true;
    }
    
    public static Block? FindBlock(IEnumerable<Block> blocks, char letter)
    {
        foreach (var block in blocks)
        {
            foreach (var blockLetter in block.Letters)
            {
                if (char.ToUpper(letter) == char.ToUpper(blockLetter))
                {
                    return block;
                }
            }
        }
        
        return null;
    }
}

namespace Abc;

public class Block
{
    public char[] Letters { get; set; }
    
    public Block(params char[] letters)
    {
        Letters = letters;
    }
    
    public override string ToString()
    {
        var letters = string.Join(",", Letters.Select(l => $"'{l}'"));
        return $"{nameof(Block)} {{ {nameof(Letters)} = [{letters}] }}";
    }
}

namespace Instruments;

interface IInstrument
{
    string Size { get; set; }
    string Name { get; set; }
    string Type { get; set; }
    void PlaySound();
}
class Instrument : IInstrument
{
    public string Size { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public virtual void PlaySound()
    {
        Console.WriteLine("Play sound");
    }

    public void test()
    {

    }
}
class KeyInstrument : Instrument
{
    public KeyInstrument()
    {
        Type = "Keyinstrument";
    }
    public override void PlaySound()
    {
        Console.WriteLine("Play key sound");
    }
}
class StringInstrument : Instrument
{
    public StringInstrument()
    {
        Type = "Stringinstrument";
    }
    override public void PlaySound()
    {
        Console.WriteLine("Play bowed sound");
    }
}
class PercussionInstrument : Instrument
{
    public PercussionInstrument()
    {
        Type = "Percussioninstrument";
    }
    public override void PlaySound()
    {
        Console.WriteLine("Play drum sound");
    }
}

class Drum : PercussionInstrument
{
    public Drum()
    {
        Size = "Big";
        Name = "Drum";
    }
}

class Piano : KeyInstrument
{
    public Piano()
    {
        Size = "Big";
        Name = "Piano";
    }
}

class Violin : StringInstrument
{
    public Violin()
    {
        Size = "Small";
        Name = "Violin";
    }
}
class InstrInventory
{
    List<IInstrument> invent = new List<IInstrument>();
    public void AddInstrument(IInstrument inst)
    {
        invent.Add(inst);
    }

    public void ListInstruments()
    {
        foreach (IInstrument inst in invent)
        {
            Console.WriteLine(inst.Name);
            inst.PlaySound();
            Console.WriteLine("");
        }
    }
}

class Hardisk : Storage
{
    public string Type { get; set; }
    public int Speed { get; set; }
    public Hardisk(string name) : base(name)
    {
    }
}

class Ram : Storage
{
    public string Generation { get; set; }
    public int Bus { get; set; }
    public Ram(string name) : base(name)
    {
    }
}



abstract class Storage : Hardware
{
    protected Storage(string name) : base(name)
    {
    }
    public override string GetName()
    {
        return base.GetName() + SerialNumber;
    }

    public  int Capacity {  get; set; }
}


class Input : Hardware
{
    public Input(string name) : base(name)
    {
    }
}
class Output : Hardware
{
    public Output(string name) : base(name)
    {
    }
}
class Processsor : Hardware
{
    public Processsor(string name) : base(name)
    {
    }
}
class Support : Hardware
{
    public Support(string name) : base(name)
    {
    }
}
class Accessory : Hardware
{
    public Accessory(string name) : base(name)
    {
    }
}
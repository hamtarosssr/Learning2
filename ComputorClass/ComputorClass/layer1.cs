class Software
{
    public string Name { get; set; }
}

interface IHardware
{
    public bool IsPortable { get; set; }
    public string Name { get; set; }
    public string SerialNumber { get; set; }
    public double Price { get; set; }
    public double PowerConsumption { get; set; }
    public string GetName();
}
abstract class Hardware : IHardware
{
    public bool IsPortable{get;set;}
    public string Name{get;set;}  = "device";
    public string SerialNumber{get;set;} = "N/A";
    public double Price { get; set; }
    public double PowerConsumption { get; set; }
    public Hardware(string name)
    {
        this.Name = name;
    }

    public virtual string GetName()
    {
        return Name;
    }
}

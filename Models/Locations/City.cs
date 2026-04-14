public class City
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PinCode { get; set; }

    public int StateId { get; set; }
    // navigations
     public State State { get; set; }

}
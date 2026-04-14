public class State
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ShortName { get; set; } 

    public int CountryId { get; set; }
 
    //neviation properties
    public Country Country { get; set; }

    public List<City> Cities { get; set; }
}
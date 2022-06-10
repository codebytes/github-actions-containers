namespace TacoApi;

public class Ingredient
{
    public string Name {get;set; } = string.Empty;
}

public class Taco
{
    public Ingredient? Shell {get; set;}
    public Ingredient? BaseLayer {get; set;}
    public Ingredient? Mixins { get; set; }
}
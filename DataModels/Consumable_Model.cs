public class Effect {
    public string Name { get; set; }
    public string Ref { get; set; }
}

public class Consumable {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Desc { get; set; }
    public Effect Effect { get; set; }
}

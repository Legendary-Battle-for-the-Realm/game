public enum CardType {
    Attack,
    Defense
}

public class ActionCard {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Desc { get; set; }
    public string Ref { get; set; }
}

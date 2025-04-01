using System.Collections.Generic;

public class Skill
{
    public string Name { get; set; }
    public string Ref { get; set; }
}

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Desc { get; set; }
    public int Atk { get; set; }
    public string Faction { get; set; }
    public List<Skill> Skill { get; set; }
}

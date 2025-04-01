public class EquipmentSkill {
    public string Name { get; set; }
    public string Ref { get; set; }
}

public class Armor {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Atk { get; set; }   // Dạng phần trăm
    public string Def { get; set; }   // Dạng phần trăm
    public string Desc { get; set; }
    public int OwnerId { get; set; }
    public string CultivationRequired { get; set; }
    public EquipmentSkill Skill { get; set; }
}

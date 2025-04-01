public class Weapon {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Atk { get; set; }   // Dạng phần trăm
    public string Desc { get; set; }
    public int OwnerId { get; set; }
    public string CultivationRequired { get; set; }
    public EquipmentSkill Skill { get; set; }
}

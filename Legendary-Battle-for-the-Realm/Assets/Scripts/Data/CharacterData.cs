using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CharacterData
{
    public int id;
    public string name;
    public string description;
    public int atk;
    public string faction;
    public List<SkillData> skill;
}
[Serializable]
public class SkillData
{
    public string name;
    public string refSkill;
}

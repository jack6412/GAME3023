using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillTest", menuName = "Object/SkillTest", order =1)]
public class Skill_Test : Skill
{
    [SerializeField]
    int damage;
    public override void Effect(Player cast, Player target)
    {
        target.Damage(damage);
    }
}

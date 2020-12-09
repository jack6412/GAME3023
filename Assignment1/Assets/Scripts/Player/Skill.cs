using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "Object/Skills", order =0)]
public abstract class Skill : ScriptableObject
{
    public abstract void Effect(Player cast, Player target);
}

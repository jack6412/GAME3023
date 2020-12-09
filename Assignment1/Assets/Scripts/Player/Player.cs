using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public int HP, HPMaxt;

    Skill[] Skills;
    public UnityEvent<int> Health;
    public UnityEvent PlayerTerm;
    public UnityEvent PlayerTermEnd;


    // Start is called before the first frame update

    public void PlayerTern()
    {
        PlayerTerm.Invoke();
    }
    public void PlayerTernEnd()
    {
        PlayerTermEnd.Invoke();
    }

    public void Damage(int D)
    {
        HP -= D;

        Health.Invoke(D);
    }
    
}

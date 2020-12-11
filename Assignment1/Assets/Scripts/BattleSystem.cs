using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


enum Phase
{
    PlayerTerm,
    EnemyTerm
}

public class BattleSystem : MonoBehaviour
{
    [SerializeField]
    Player[] players = new Player[2];
    [SerializeField]
    Phase CurrentTerm = Phase.PlayerTerm;
    [SerializeField]
    public Text message;

    private void Start()
    {
        //NextTerm();
    }
    private void Update()
    {
        
    }


    //Button action
    public void Attack()
    {
        players[(int)CurrentTerm].PlayerTernEnd();

        //Switch turn
        CurrentTerm = (Phase)(((int)CurrentTerm + 1) % 2);


        players[(int)CurrentTerm].PlayerTern();

        StartCoroutine(TextLog(players[(int)CurrentTerm].gameObject.name, " Attack."));

        Debug.Log("Attack");
    }
    public void Deffend()
    {
        players[(int)CurrentTerm].PlayerTernEnd();

        //Switch turn
        CurrentTerm = (Phase)(((int)CurrentTerm + 1) % 2);


        players[(int)CurrentTerm].PlayerTern();

        StartCoroutine(TextLog(players[(int)CurrentTerm].gameObject.name, " Defend."));

        Debug.Log("Deffend");
    }
    public void Skill()
    {
        players[(int)CurrentTerm].PlayerTernEnd();

        //Switch turn
        CurrentTerm = (Phase)(((int)CurrentTerm + 1) % 2);


        players[(int)CurrentTerm].PlayerTern();

        StartCoroutine(TextLog(players[(int)CurrentTerm].gameObject.name, " use Skill."));

        Debug.Log("Skills");
    }
    public void Escape()
    {
        players[(int)CurrentTerm].PlayerTernEnd();

        //Switch turn
        CurrentTerm = (Phase)(((int)CurrentTerm + 1) % 2);


        players[(int)CurrentTerm].PlayerTern();

        StartCoroutine(TextLog(players[(int)CurrentTerm].gameObject.name, " Escape."));

        Debug.Log("Escape");
    }

    IEnumerator TextLog(string text, string M)
    {
        //message.text = text;
        string t = "";
        int max = text.Length + M.Length;
        //string t1[max];

        for (int i=0;i<max;i++)
        {
            if(i< text.Length)
                t += text[i]; //who turn
            else
                t += M[i- text.Length]; //what they are doing

            message.text = t;//print message
            yield return new WaitForSeconds(0.1f);
        }


    }
}
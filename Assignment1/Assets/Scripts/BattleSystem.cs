using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;


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

    public AudioClip Attack_sound;
    public AudioClip Defend_sound;
    public AudioClip escape_sound;
    public AudioClip Heal_sound;

    public SceneAsset tag_Name;

    bool finish = false;
    bool esc = false;


    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    //Button action
    public void Attack()
    {
        if (finish == false)
        {
            finish = true;
            gameObject.AddComponent<AudioSource>();

            source.PlayOneShot(Attack_sound);

            players[(int)CurrentTerm].PlayerTernEnd();

            //Switch turn
            CurrentTerm = (Phase)(((int)CurrentTerm + 1) % 2);


            players[(int)CurrentTerm].PlayerTern();

            StartCoroutine(TextLog(players[(int)CurrentTerm].gameObject.name, " Attack."));

            Debug.Log("Attack");
        }
    }
    public void Deffend()
    {
        if (finish == false)
        {
            finish = true;
            gameObject.AddComponent<AudioSource>();

            source.PlayOneShot(Defend_sound);

            players[(int)CurrentTerm].PlayerTernEnd();

            //Switch turn
            CurrentTerm = (Phase)(((int)CurrentTerm + 1) % 2);


            players[(int)CurrentTerm].PlayerTern();

            StartCoroutine(TextLog(players[(int)CurrentTerm].gameObject.name, " Defend."));

            Debug.Log("Deffend");
        }
    }
    public void Heal()
    {
        if (finish == false)
        {
            finish = true;
            gameObject.AddComponent<AudioSource>();

            source.PlayOneShot(Heal_sound);

            players[(int)CurrentTerm].PlayerTernEnd();

            //Switch turn
            CurrentTerm = (Phase)(((int)CurrentTerm + 1) % 2);


            players[(int)CurrentTerm].PlayerTern();

            StartCoroutine(TextLog(players[(int)CurrentTerm].gameObject.name, " use Heal."));

            Debug.Log("Skills");
        }
    }
    public void Escape()
    {
        if (finish == false)
        {
            finish = true;

            gameObject.AddComponent<AudioSource>();


            players[(int)CurrentTerm].PlayerTernEnd();

            //Switch turn
            CurrentTerm = (Phase)(((int)CurrentTerm + 1) % 2);


            players[(int)CurrentTerm].PlayerTern();

            if(Random.Range(0,2)>=1)
            {
                esc = true;
                source.PlayOneShot(escape_sound);
                StartCoroutine(TextLog(players[(int)CurrentTerm].gameObject.name, " has been Escape."));
            }
            else
                StartCoroutine(TextLog(players[(int)CurrentTerm].gameObject.name, " Escape fell."));


            //Debug.Log("Escape " + finish);
        }
            
        
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

        finish = false;
        Debug.Log("text "+finish);

        //escape action
        if(esc == true && finish == false)
        {
            SceneManager.LoadScene(tag_Name.name);
            esc = false;
        }
    }
}
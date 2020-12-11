using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleTriger : MonoBehaviour
{
    public AudioClip sound;

    //public Animator Start;

    private AudioSource source { get { return GetComponent<AudioSource>(); } }

    void Update()
    {
        Vector2 movementVector = new Vector2(Input.GetAxis("Horizontal"),
                                             Input.GetAxis("Vertical"));
        if (movementVector != Vector2.zero)
        {
            if (UnityEngine.Random.Range(0, 1000) == 0)
            {
                gameObject.AddComponent<AudioSource>();
                source.PlayOneShot(sound);

                StartCoroutine(ChangeScene());
                
                //Debug.Log("Battle");
            }
            
        }
    }
    IEnumerator ChangeScene()
    {
        //Start.SetTrigger("BattleStart");
        yield return new WaitForSeconds(0);
        SceneManager.LoadScene(tag);
    }

}

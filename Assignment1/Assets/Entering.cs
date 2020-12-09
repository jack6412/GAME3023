using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Entering : MonoBehaviour
{

    public float WaitTime;

    public Animator MusicAnimation;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        MusicAnimation.SetTrigger("FadOut");
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene(tag);
    }
}

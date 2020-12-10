using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Menu : MonoBehaviour
{
    public float WaitTime;

    public GameObject Start_Scream;
    public GameObject User_Scream;

    public void StartGame()
    {
        User_Scream.gameObject.SetActive(true);
        Start_Scream.gameObject.SetActive(false);
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene(tag);
    }

    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}

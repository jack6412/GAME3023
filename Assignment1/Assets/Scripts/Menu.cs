using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(tag);
    }

    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}

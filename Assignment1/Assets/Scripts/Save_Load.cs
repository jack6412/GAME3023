using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Diagnostics;

public class Save_Load : MonoBehaviour
{
    public GameObject View;
    public GameObject setting;

    public void PlayerPositionSave()
    {

        string Position = transform.position.x.ToString() + "," + transform.position.y.ToString();
        string scrip = gameObject.tag;
        PlayerPrefs.SetString("Location", Position);
        PlayerPrefs.Save();

        UnityEngine.Debug.Log(scrip);

        View.gameObject.SetActive(false);
        setting.gameObject.SetActive(true);
    }

    public void PlayerPositionLoad()
    {

        string Load = PlayerPrefs.GetString("Location");

        if(Load != "")
        {
            string[] data = Load.Split(',');


            transform.position = new Vector2(float.Parse(data[0]), float.Parse(data[1]));
        }

    }
}

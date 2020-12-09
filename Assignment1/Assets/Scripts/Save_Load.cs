using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Diagnostics;

public class Save_Load : MonoBehaviour
{

    public void PlayerPositionSave()
    {

        string Position = transform.position.x.ToString() + "," + transform.position.y.ToString();
        PlayerPrefs.SetString("Location", Position);
        PlayerPrefs.Save();
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public GameObject View;
    public GameObject setting;

    public void ViewSetting()
    {
        View.gameObject.SetActive(true);
        setting.gameObject.SetActive(false);
            //View.gameObject.SetActive(false);
    }

}

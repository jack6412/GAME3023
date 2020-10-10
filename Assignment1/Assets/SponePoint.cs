using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SponePoint : MonoBehaviour
{
    [SerializeField]
    GameObject playerPrefab;

    static PlayerCharacterController player = null;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
            player = Instantiate(playerPrefab, transform.position, transform.rotation).GetComponent<PlayerCharacterController>();


    }
}

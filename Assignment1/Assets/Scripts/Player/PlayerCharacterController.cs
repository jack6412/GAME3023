using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D rb;
    float speed = 5;

    public LayerMask name;

    // Update is called once per frame
    void Update()
    {
        Vector2 movementVector = new Vector2(Input.GetAxis("Horizontal"),
                                             Input.GetAxis("Vertical"));
        movementVector *= speed;

        rb.velocity = movementVector;

        CheckBattle(name);
    }

    private void CheckBattle(LayerMask n)
    {
        if(n == LayerMask.GetMask("CaveBattle"))
        {
            if (Random.Range(0, 100) <= 10)
                Debug.Log("Battle");
        }
    }
}

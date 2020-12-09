using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D rb;
    float speed = 5;

    // Update is called once per frame
    void Update()
    {
        Vector2 movementVector = new Vector2(Input.GetAxis("Horizontal"),
                                             Input.GetAxis("Vertical"));
        movementVector *= speed;



        rb.velocity = movementVector;
    }
}

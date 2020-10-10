using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello World");
        Vector2 movementVector = new Vector2(Input.GetAxis("Horizontal"),
                                             Input.GetAxis("Vertical"));
        //movementVector *= Time.deltaTime * speed;
        movementVector *= speed;

        //transform.Translate(movementVector);

        rb.velocity = movementVector;
    }
}

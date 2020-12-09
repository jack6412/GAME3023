using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerDirection
{
    NORTH = 0,
    EAST = 1,
    SOUTH = 2,
    WEST = 3
}

public class Player_Animater : MonoBehaviour
{
    [SerializeField]
    Animator PlayerAnimation;

    [SerializeField]
    PlayerDirection Direction = PlayerDirection.SOUTH;

    [SerializeField]
    Rigidbody2D rb;




    // Update is called once per frame
    private void Update()
    {
        Vector2 velocityDir = rb.velocity.normalized;

        //PlayerAnimation.SetFloat("Speed", Mathf.Abs(moveY));

        if (velocityDir.y > 0.0)
            Direction = PlayerDirection.NORTH;
        if (velocityDir.y < 0.0)
            Direction = PlayerDirection.SOUTH;


        if (velocityDir.x > 0.0)
            Direction = PlayerDirection.EAST;
        if (velocityDir.x < 0.0)
            Direction = PlayerDirection.WEST;

        //Debug.Log("X: " + velocityDir.x + "Y: " + velocityDir.y);

        PlayerAnimation.SetFloat("MoveX", Input.GetAxis("Horizontal"));
        PlayerAnimation.SetFloat("MoveY", Input.GetAxis("Vertical"));
        PlayerAnimation.SetInteger("Walk", (int)Direction);
    }
}

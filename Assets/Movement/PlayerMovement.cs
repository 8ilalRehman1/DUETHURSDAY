using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerspeed = 10;
    public int playerjumppower = 500;
    public float movex;

    // Update is called once per frame
    void Update()
    {
        player_Move();
    }
    void player_Move()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            jump();
        }

        movex = Input.GetAxis("Horizontal");

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(movex * playerspeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerjumppower);
    }
}

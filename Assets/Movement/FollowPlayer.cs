using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject objectToInstantiate;
    public Transform player;
    public int speed = 9;
    private GameObject instantiatedObject;
    private Transform copyplayer;
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Instantiate the object and store a reference to it
            instantiatedObject = Instantiate(objectToInstantiate, transform.position, Quaternion.identity);

            // Calculate the direction towards the player
            Vector2 direction = (player.position - instantiatedObject.transform.position).normalized;

            // Move the instantiated object towards the player
            instantiatedObject.GetComponent<Rigidbody2D>().velocity = direction * speed;
            instantiatedObject.GetComponent<Rigidbody2D>().position = player.position;
        }
        
    }

}

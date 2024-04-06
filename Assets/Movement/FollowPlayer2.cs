using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    public GameObject objectToInstantiate2;
    public Transform player2;
    public int speed2 = 9;
    private GameObject instantiatedObject2;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            // Instantiate the object and store a reference to it
            instantiatedObject2 = Instantiate(objectToInstantiate2, transform.position, Quaternion.identity);

            // Calculate the direction towards the player
            Vector2 direction = (player2.position - instantiatedObject2.transform.position).normalized;

            // Move the instantiated object towards the player
            instantiatedObject2.GetComponent<Rigidbody2D>().velocity = direction * speed2;
        }

    }
}

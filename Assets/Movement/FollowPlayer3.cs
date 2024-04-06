using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer3 : MonoBehaviour
{
    
    public GameObject objectToInstantiate3;
    public Transform player3;
    public int speed3 = 9;
    private GameObject instantiatedObject3;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            // Instantiate the object and store a reference to it
            instantiatedObject3 = Instantiate(objectToInstantiate3, transform.position, Quaternion.identity);

            // Calculate the direction towards the player
            Vector2 direction = (player3.position - instantiatedObject3.transform.position).normalized;

            // Move the instantiated object towards the player
            instantiatedObject3.GetComponent<Rigidbody2D>().velocity = direction * speed3;
        }

    }
}

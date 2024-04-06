using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer4 : MonoBehaviour
{
    public GameObject objectToInstantiate4;
    public Transform player4;
    public int speed4 = 9;
    private GameObject instantiatedObject4;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Instantiate the object and store a reference to it
            instantiatedObject4 = Instantiate(objectToInstantiate4, transform.position, Quaternion.identity);

            // Calculate the direction towards the player
            Vector2 direction = (player4.position - instantiatedObject4.transform.position).normalized;

            // Move the instantiated object towards the player
            instantiatedObject4.GetComponent<Rigidbody2D>().velocity = direction * speed4;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMushroomScale : MonoBehaviour
{
    public GameObject mushroomGow;
    public Transform SpawnHere;
    private GameObject newObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyAndInstantiate();
    }

    public void DestroyAndInstantiate()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Destroy(gameObject);
            newObject = Instantiate(mushroomGow, SpawnHere.position, Quaternion.identity);
            Debug.Log("Scale");
        }
    }
}

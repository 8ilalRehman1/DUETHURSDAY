using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADonutRotate : MonoBehaviour
{
    public bool isRotate = false;
    public int rotateSpeed = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotating();
        rotateOn();
        
    }
    private void Rotating()
    {
        if (isRotate==true)
        {
            transform.Rotate(rotateSpeed * Time.deltaTime * Vector3.forward);
        }
    }

    private void rotateOn()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            isRotate = !isRotate;
            Debug.Log("Rotate");
        }
    }
}

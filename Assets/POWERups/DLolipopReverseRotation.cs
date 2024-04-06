using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DLolipopReverseRotation : MonoBehaviour
{
    public int speed = 15;
    public bool reverseRotateOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ReverseRotation();
        ReverseRotateOn();
    }
    private void ReverseRotation()
    {
        if (reverseRotateOn == true)
        {
            transform.Rotate(speed * Time.deltaTime * Vector3.back);
        }
    }
    private void ReverseRotateOn()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            reverseRotateOn = !reverseRotateOn;
            Debug.Log("Reverse Rotate");
        }
    }
}

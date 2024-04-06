using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BCookieMove : MonoBehaviour
{
    public Transform platform;
    public Transform startPoint;
    public Transform endPoint;

    int direction = 1;
    public float speed = 1.5f;
    public bool translate = false;

    private void OnDrawGizmos()
    {
        if (platform!=null && startPoint!=null && endPoint != null)
        {
            Gizmos.DrawLine(platform.transform.position, startPoint.position);
            Gizmos.DrawLine(platform.transform.position, endPoint.position);
        }
    }

    Vector2 currentMovementTarget()
    {
        if(direction==1)
        {
            return startPoint.position;
        }
        else { return endPoint.position;}
    } 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnTranslate();

        Translation();
        
    }

    private void OnTranslate()
    {
        if (Input.GetKeyDown(KeyCode.T)) 
        {
            translate = !translate;
            Debug.Log("Translate");
        }
    }

    private void Translation()
    {
        if (translate == true)
        {
            Vector2 target = currentMovementTarget();

            platform.position = Vector2.Lerp(platform.position, target, speed * Time.deltaTime);

            float distance = (target - (Vector2)platform.position).magnitude;

            if (distance <= 0.1f)
            {
                direction *= -1;
            }
        }
    }
}

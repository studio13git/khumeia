using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHover : MonoBehaviour
{

    public float horizontalSpeed;
    public float verticalSpeed;
    public float amplitude;
    public float xBoundary;
    
    public Vector3 tempPosition;

    // Start is called before the first frame update
    void Start()
    {
        tempPosition = transform.position;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position > 3.4){
        tempPosition.x += horizontalSpeed;
        tempPosition.y += Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude;
        transform.position = tempPosition;
        }
        else if (transform.position < -3.4 )
        
    }
}

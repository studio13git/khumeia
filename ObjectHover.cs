using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHover : MonoBehaviour
{

    public float horizontalSpeed;
    public float verticalSpeed;
    public float amplitude;
    public float xBoundary;
    public bool movingRight;
    
    public Vector3 tempPosition;

    // Start is called before the first frame update
    void Start()
    {
        tempPosition = transform.position;
        movingRight = true;

    }
    void OnMouseDown() {
            Debug.Log("Clicked!");
        }
    // Update is called once per frame
    void FixedUpdate()
    {
        //controls the hovering of the cube
        tempPosition.y += Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude;

        
        if (movingRight == true ){
        tempPosition.x += horizontalSpeed;
        transform.position = tempPosition;
            if ( transform.position.x > 5){
                movingRight = false;
            }

        }        
        else if (movingRight == false ){
        tempPosition.x -= horizontalSpeed;
        transform.position = tempPosition;
          if ( transform.position.x < -5){
                movingRight = true;
            }

        }
        
      
        

        

        
    }
}

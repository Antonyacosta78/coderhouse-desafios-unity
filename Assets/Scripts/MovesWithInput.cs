using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovesWithInput : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 1.0f;
    [SerializeField] private float rotationSpeed = 1.0f;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveWhenKeyPressed(KeyCode.W, Vector3.forward);
        MoveWhenKeyPressed(KeyCode.S, Vector3.back);
        MoveWhenKeyPressed(KeyCode.A, Vector3.left);
        MoveWhenKeyPressed(KeyCode.D, Vector3.right); 

        RotateWhenKeyPressed(KeyCode.LeftArrow, -0.75f);
        RotateWhenKeyPressed(KeyCode.RightArrow, 0.75f);
    }

    void MoveWhenKeyPressed(KeyCode input, Vector3 dir) 
    {
        if(Input.GetKey(input))
        {
            transform.Translate(dir * movementSpeed * Time.deltaTime);
        }
    }

    void RotateWhenKeyPressed(KeyCode input, float rotation)
    {
        if(Input.GetKey(input))
        {
            transform.localRotation = transform.localRotation * Quaternion.Euler(0, rotationSpeed * rotation, 0);
        }
    }
    
}

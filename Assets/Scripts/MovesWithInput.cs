using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovesWithInput : MonoBehaviour
{
    
    [SerializeField] private float speed = 1.0f;

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
    }

    void MoveWhenKeyPressed(KeyCode input, Vector3 dir) 
    {
        if(Input.GetKey(input))
        {
            transform.position += dir * speed * Time.deltaTime;
        }
    }
    
}

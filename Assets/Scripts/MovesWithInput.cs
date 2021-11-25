using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovesWithInput : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 1.0f;
    [SerializeField] private float sensitivity = 2.0f;

    float cameraAxisX = 0f;
    float cameraAxisY = 0f;

    private Dictionary<KeyCode, Vector3> movementBindings = new Dictionary<KeyCode, Vector3>()
    {
        { KeyCode.W, Vector3.forward },
        { KeyCode.S, Vector3.back },
        { KeyCode.A, Vector3.left },
        { KeyCode.D, Vector3.right },
    };
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        foreach (var item in movementBindings)
        {
            MoveWhenKeyPressed(item.Key, item.Value);
        }

        FollowAxis();
    }

    void MoveWhenKeyPressed(KeyCode input, Vector3 dir) 
    {
        if(Input.GetKey(input))
        {
            transform.Translate(dir * movementSpeed * Time.deltaTime);
        }
    }

    void FollowAxis() 
    {
        cameraAxisX -= Input.GetAxisRaw("Mouse Y");
        cameraAxisY += Input.GetAxisRaw("Mouse X");

        transform.localRotation = Quaternion.Euler(cameraAxisX * sensitivity, cameraAxisY * sensitivity, 0);

        Debug.Log($"AxisX: {cameraAxisX}, AxisY: {cameraAxisY}");
    }
    
}

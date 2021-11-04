using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportsWithTimeout : MonoBehaviour
{

    private float timeout = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void resetTimeout()
    {

        timeout = 2f;
    }

    void teleport() 
    {
        var random = new System.Random();
        transform.position = new Vector3(random.Next(-5, 5), random.Next(-5, 5), random.Next(-5, 5));
        transform.localRotation = new Quaternion(random.Next(-5, 5), random.Next(-5, 5), random.Next(-5, 5), random.Next(-5, 5));
    }

    void OnCollisionStay(Collision collision)
    {
        timeout -= Time.deltaTime;

        if(timeout <= 0) {
            teleport();
            resetTimeout();
        }
    }

}

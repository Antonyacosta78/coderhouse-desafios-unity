using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootsBullets : MonoBehaviour
{
    public GameObject bulletObject;

    public Vector3 offset = new Vector3(0, 0, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        Disparo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Disparo()
    {
        Instantiate(bulletObject, transform.position + offset, Quaternion.identity);
    }
}

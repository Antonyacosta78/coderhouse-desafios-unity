using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootsBullets : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Vector3 BulletDirection = Vector3.forward;
    public float SpawnInterval = 5.0f;
    public float DespawnInSeconds = 6.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Shoot()
    {
        var bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity);
        var bulletScript = bullet.GetComponent<Bullet>();
        bulletScript.direction = BulletDirection;
        bulletScript.SetDespawnTimeout(DespawnInSeconds);
    } 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Vector3 direction = Vector3.forward;
    private float? despawnTimer = null;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        updateDespawnTimer();
        if ( shouldDespawn() ) {
            despawn();
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            transform.localScale *= 2;
        }

        move();
    }

    private void move()
    {
        transform.position += direction * Time.deltaTime * 10;
    }

    private bool shouldDespawn()
    {
        if (despawnTimer == null) {
            return false;
        }
        return despawnTimer <= 0;
    }

    private void updateDespawnTimer()
    {
        if (despawnTimer != null) {
            despawnTimer -= Time.deltaTime;
        }
    }

    private void despawn()
    {
        Destroy(gameObject);
    }

    public void SetDespawnTimeout(float time)
    {
       despawnTimer = time;
    }
}

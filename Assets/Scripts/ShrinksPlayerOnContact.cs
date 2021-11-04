using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinksPlayerOnContact : MonoBehaviour
{

    private GameObject player;

    private float shrinkTimeout = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");       
    }

    // Update is called once per frame
    void Update()
    {
        if(shrinkTimeout > 0f) {
            shrinkTimeout -= Time.deltaTime;
        }
    }

    void startShrinkTimeout(float time = 0.75f)
    {
        shrinkTimeout = time;
    }

    bool canShrink() 
    {
        return shrinkTimeout <= 0f;
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collided with " + this.name + ". This object has the script ShrinksPlayerOnContact that shrinks the player on contact");
        if(canShrink()) {
            startShrinkTimeout();
            player.GetComponent<TogglesSize>().ToggleSize();
        }
    }

}

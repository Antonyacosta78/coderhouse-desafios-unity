using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 enum EnemyState {
    IDLE,
    WATCHING,
    FOLLOWING,
}

public class ReactsToPlayer : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 4.0f;
    [SerializeField] private EnemyState state = EnemyState.IDLE;
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(state) {
            case EnemyState.WATCHING:
                stareAtPlayer();
                break;
            case EnemyState.FOLLOWING:
                followPlayer();
                break;
        }   
    }

    private void stareAtPlayer()
    {
        Vector3 direction = player.transform.position - transform.position;
        var newQuaternion = Quaternion.LookRotation(direction);
        transform.rotation = newQuaternion;
    }

    private bool canApproach()
    {
        return Mathf.Abs(transform.position.x - player.transform.position.x) >= 2.0f;
    }

    private void followPlayer()
    {
        if(canApproach()) {
            Vector3 direction = (player.transform.position - transform.position).normalized;
            transform.Translate(movementSpeed * direction * Time.deltaTime);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglesSize : MonoBehaviour
{
    [SerializeField] private bool small = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleSize()
    {
        if(small) {
            transform.localScale = new Vector3(1, 1, 1);
        } else {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        small = !small;
    }
}

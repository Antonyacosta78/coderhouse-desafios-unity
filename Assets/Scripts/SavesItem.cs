using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavesItem : MonoBehaviour
{

    [SerializeField] private GameObject castDirection; 
    [SerializeField] private GameObject spawnPosition; 
    // [SerializeField] private float distance = 5.0f; 
    private List<GameObject> inventory = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        float distance = Vector3.Distance(this.transform.position, castDirection.transform.position);

        if(Physics.Raycast(this.transform.position, castDirection.transform.position, out hit, distance)) 
        {
            if(Input.GetKey(KeyCode.Space)) 
            {
               storeToInventory(hit.transform.gameObject.name);
            } 
        } 
        else if (Input.GetKey(KeyCode.E)) 
        {
            placeLastObject();
        }
        
    }

    void storeToInventory(string itemName) 
    {
        GameObject item = GameObject.Find(itemName);
        inventory.Add(item);
        item.SetActive(false);
    }

    void placeLastObject()
    {
        if( inventory.Count > 0 )
        {
            GameObject item = inventory[inventory.Count - 1];
            item.transform.SetPositionAndRotation(spawnPosition.transform.position, Quaternion.identity);
            item.SetActive(true);
            inventory.RemoveAt(inventory.Count - 1);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(this.transform.position, castDirection.transform.position);
    }




}

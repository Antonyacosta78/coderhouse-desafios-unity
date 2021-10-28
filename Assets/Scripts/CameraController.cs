using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private GameObject[] cameras;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        ActivateWithKey(KeyCode.F1, 0);        
        ActivateWithKey(KeyCode.F2, 1);        
        ActivateWithKey(KeyCode.F3, 2);        
    }

    void ActivateWithKey(KeyCode input, int cameraIndex)
    {
        if(Input.GetKey(input))
        {
            cameras[cameraIndex].SetActive(true);

            for (int index = 0; index < cameras.Length; index++)
            {
                if(index == cameraIndex) continue;
                cameras[index].SetActive(false);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private GameObject[] cameraList;
    private int currentCameraIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        //find current active camera
        for(var i = 0; i < cameraList.Length; i++)
        {   
            if (cameraList[i].activeSelf) {
                currentCameraIndex = i;
                break;
            }
        }
        deactivateAllExcept(currentCameraIndex);
    }

    // Update is called once per frame
    void Update()
    {
        // previous camera
        if(Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            previousCamera();
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)) {
            nextCamera();
        }
    }

    void previousCamera()
    {
        if(currentCameraIndex == 0) 
        {
            currentCameraIndex = cameraList.Length - 1;
        }
        else
        {
            currentCameraIndex--;
        }
        setCamera(currentCameraIndex);
    }

    void nextCamera()
    {
        if(currentCameraIndex == cameraList.Length - 1) 
        {
            currentCameraIndex = 0;
        }
        else
        {
            currentCameraIndex++;
        }
        setCamera(currentCameraIndex);
    }

    void setCamera(int index)
    {
        //deactivate all cameras
        foreach (var item in cameraList)
        {   
            item.SetActive(false);
        }

        cameraList[index].SetActive(true);
    }

    void deactivateAllExcept(int index)
    {   
        //looping the other way around
        for(var i = cameraList.Length - 1 ; i > 0; i--)
        {   
            if (i == index) {
                continue;
            }

            cameraList[i].SetActive(false);
        }
    }
}

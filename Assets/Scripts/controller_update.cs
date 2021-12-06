using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;

public class controller_update : MonoBehaviour
{
    public GameObject linePointer;
    private void Start()
    {
        //Debug.Log(linePointer.activeInHierarchy);
        //Debug.Log(!linePointer.activeInHierarchy);
    }
    void Update()
    {
        if (ViveInput.GetPressDown(HandRole.RightHand, ControllerButton.AKey) || ViveInput.GetPressDown(HandRole.LeftHand, ControllerButton.AKey)) 
        {
            linePointer.SetActive(!linePointer.activeInHierarchy);
        }
    }
}


using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using System.Collections;

public class hotkey : UdonSharpBehaviour
{

    public GameObject Target; 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Target.SetActive(!Target.activeSelf);
        }
    }
}

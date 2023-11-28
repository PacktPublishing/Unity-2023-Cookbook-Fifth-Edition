using UnityEngine;
using System;
using UnityEngine.InputSystem;


public class Snapshot : MonoBehaviour
{
    public InputActionReference printScreen;
    
    private void Update()
    {
        if (printScreen.action.WasPressedThisFrame())
        {
            SaveScreenSnapshot();
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        SaveScreenSnapshot();
    }

    private void SaveScreenSnapshot()
    {
        print("taking snapshot");
        string timeStamp = DateTime.Now.ToString("HH_mm_ss");
        ScreenCapture.CaptureScreenshot("snapshot_" + timeStamp + ".png");
    }
}

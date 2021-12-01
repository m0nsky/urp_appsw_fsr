using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppSpaceWarpHelper : MonoBehaviour
{
    bool bSWToggle;

    // Start is called before the first frame update
    protected void Start()
    {
        bSWToggle = false;
    }

    // Update is called once per frame
    protected void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B, OVRInput.Controller.RTouch))
        {
            bSWToggle = !bSWToggle;
            OVRManager.SetSpaceWarp(bSWToggle);
        }
    }
}

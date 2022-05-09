using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : Singleton<CameraManager>
{
    private GameObject camGroup;    // Camera Group  
    private ShakeCamera shakeCam;   // Cinemachine Cam

    protected override void Awake()
    {
        base.Awake();

        camGroup = GameObject.Find("CamGroup");
        shakeCam = camGroup.GetComponentInChildren<ShakeCamera>();
    }



    public static void ShakeCam(float intense, float during)
    {
        Instance.shakeCam.SetShake(intense, during);
    }
}

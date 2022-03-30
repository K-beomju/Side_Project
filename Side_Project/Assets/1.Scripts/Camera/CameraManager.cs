using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : Singleton<CameraManager>
{
    private ShakeCamera shakeCam;

    protected override void Awake()
    {
        // base.Awake();
        if (shakeCam != null)
            shakeCam = GetComponent<ShakeCamera>();
    }

    public static void ShakeCam(float intense, float during)
    {
        Instance.shakeCam.SetShake(intense, during);
    }
}

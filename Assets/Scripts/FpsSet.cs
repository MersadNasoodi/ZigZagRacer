using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsSet : MonoBehaviour
{
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 61;
    }


}

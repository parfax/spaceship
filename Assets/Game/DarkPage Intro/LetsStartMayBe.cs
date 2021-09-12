using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetsStartMayBe : MonoBehaviour {
    public float TimeStart;
    public float TimeEnd = 220;
    public float SpeedTime = 1;
    void FixedUpdate()
    {
        TimeStart += SpeedTime;
        if (TimeStart == TimeEnd)
        {
            SceneManager.LoadScene("Main");
        }
    }
}

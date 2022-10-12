using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeToDeactiveAudio : MonoBehaviour {
    public int TimeStart;
    public int TimeEnd;
    public int TimeSpeed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TimeStart += TimeSpeed;
            if(TimeStart >= TimeEnd)
            {
              GetComponent<AudioSource>().enabled = false;
            }
	}
}

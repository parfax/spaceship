using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToDestroy : MonoBehaviour {
    public float TimeStart;
    public float TimeEnd;
    public float TimeSpeed = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TimeStart += TimeSpeed;
        if(TimeStart >= TimeEnd)
        {
            Destroy(gameObject);
        }
    }
}

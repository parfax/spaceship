using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public int hp = 100;
    public AudioClip enemShot;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject fire;
    public GameObject explosion;
    public float TimeStart;
    public float TimeEnd;
    public float TimeSpeed = 1f;
    // Use this for initialization
    void Start () {
		
	}
    // Update is called once per frame
    void FixedUpdate () {
        TimeStart += TimeSpeed;
        if (TimeStart >= TimeEnd)
        {
            Instantiate(fire, spawn1.transform);
            Instantiate(fire, spawn2.transform);
            GetComponent<AudioSource>().PlayOneShot(enemShot);
            TimeStart = 0;
        }
        if(hp <= 0)
        {
            hp = 0;
            explosion.transform.position = transform.position;
            Instantiate(explosion);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
            col.gameObject.GetComponent<SkyTanker>().hp = 0;
        if (col.tag == "destroy")
            Destroy(gameObject);
    }
}

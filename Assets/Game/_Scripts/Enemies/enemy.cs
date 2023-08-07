using System;
using UnityEngine;

public class enemy : MonoBehaviour {
    public int health = 100;

    [SerializeField] private GameObject spawn1, spawn2, firePrefab, explosionPrefab;

    private float TimeStart;
    [SerializeField] private float TimeEnd, TimeSpeed = 1f;

    [SerializeField] private AudioClip enemShot;
    private AudioSource audioSource;

    void Start () {
        audioSource = GetComponent<AudioSource>();

    }

    void FixedUpdate () {
        TimeStart += TimeSpeed;
        if (TimeStart >= TimeEnd)
        {
            GameObject fire1 = Instantiate(firePrefab);
            fire1.transform.position = spawn1.transform.position;

            GameObject fire2 = Instantiate(firePrefab);
            fire2.transform.position =  spawn2.transform.position;

            audioSource.PlayOneShot(enemShot);
            TimeStart = 0;
        }
        if(health <= 0)
        {
            health = 0;
            GameObject explosion = Instantiate(explosionPrefab);
            explosion.transform.position = transform.position;
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

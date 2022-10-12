using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss : MonoBehaviour
{
    public float speed;
    private Transform target;
    public Vector2 yy;
    public Vector2 yy1;

    public int hp;
    public Text hptxt;
    public AudioClip enemShot;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    public GameObject fire;
    public GameObject explosion;
    public float TimeStart;
    public float TimeEnd;
    public float TimeSpeed = 1f;
    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        yy = new Vector2(target.position.x, yy1.y);
        transform.position = Vector2.MoveTowards(transform.position, yy, speed * Time.deltaTime);
        
        hptxt.text = hp + " hp";
        TimeStart += TimeSpeed;
        if (TimeStart >= TimeEnd)
        {
            Instantiate(fire, spawn1.transform);
            Instantiate(fire, spawn2.transform);
            Instantiate(fire, spawn3.transform);
            Instantiate(fire, spawn4.transform);
            GetComponent<AudioSource>().PlayOneShot(enemShot);
            TimeStart = 0;
        }
        if (hp <= 0)
        {
            hp = 0;
            GameObject.FindGameObjectWithTag("spwnMngr").GetComponent<SpawnMngr>().isBoss = false;
            explosion.transform.position = transform.position;
            Instantiate(explosion);
            Destroy(gameObject);
        }
    }
}
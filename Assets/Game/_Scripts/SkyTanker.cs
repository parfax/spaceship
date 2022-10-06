using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SkyTanker : MonoBehaviour {
    public int ammo, hp = 100;
    public Text txtAmmo;
    public float speed, speedHor;
    public Vector2 xx, yy;
    public Slider sldr;
    public GameObject spawn1, spawn2, firePrefab, Gorit, explosion, gameEnd;
    public bool isGorit;
    public AudioClip myshot;
    public bool b;

    // Update is called once per frame
    void FixedUpdate()
    {
        txtAmmo.text = "Ammo " + ammo;

        if (isGorit)
        {
            Gorit.SetActive(true);
            isGorit = false;
        }
        sldr.value = hp;



        if (Input.GetKey(KeyCode.A))
        {
            speed -= speedHor;
        }
        if (Input.GetKey(KeyCode.D))
        {
            speed = speedHor;
        }



        if (transform.position.x >= 7)
        {
            transform.position = xx;
        }
        if (transform.position.x <= -7)
        {
            transform.position = yy;
        }



        transform.Translate(speed, 0, 0);
        speed = 0;

        if (hp <= 0)
        {
            hp = 0; 
            explosion.transform.position = transform.position;
            Instantiate(explosion);
            gameEnd.SetActive(true);
            Destroy(gameObject);
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            Firer();
        }
    }
    private void Update()
    {
        if (ammo <= 25)
        {
            if(!b)
             StartCoroutine(Faded());
        }
        else
        {
            Color temp = txtAmmo.color;
            temp.a = 1;
            txtAmmo.color = temp;
        }
    }
    void Firer()
    {
        if (ammo >= 1)
        {
            if (ammo >= 2) {
                if (spawn2.active)
                {
                    Instantiate(firePrefab, spawn2.transform);
                    ammo--;
                }
            }
            Instantiate(firePrefab, spawn1.transform);
            GetComponent<AudioSource>().PlayOneShot(myshot);
            ammo--;
        }
    }
    public void ShootFire()
    {
        Firer();
    }
    IEnumerator Faded()
    {
        Color temp = txtAmmo.color;
        b = true;
        for (int i = 10; i > 0; i--)
        {
            temp.a = i * 0.1f;
            txtAmmo.color = temp;
            yield return new WaitForSeconds(.05f);
        }
        b = false;
    }
}

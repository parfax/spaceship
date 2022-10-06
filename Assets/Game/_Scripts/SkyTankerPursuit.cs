using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkyTankerPursuit : MonoBehaviour
{
    public int ammo, hp = 100;
    public Text txtAmmo;
    public float speed;
    public Slider sldr;
    public GameObject spawn1, spawn2, firePrefab, Gorit, explosion, gameEnd;
    public bool isGorit;
    public AudioClip myshot;
    public bool b, isLeft,isRight;

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
        transform.Translate(0, speed, 0);
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
            if (!b)
                StartCoroutine(Faded());
        }
        else
        {
            Color temp = txtAmmo.color;
            temp.a = 1;
            txtAmmo.color = temp;
        }
        if (isLeft)
            transform.Rotate(0, 0, 2);
        if (isRight)
            transform.Rotate(0, 0, -2);
    }
    void Firer()
    {
        if (ammo >= 1)
        {
            if (ammo >= 2)
            {
                if (spawn2.active == true)
                {
                    Instantiate(firePrefab, spawn2.transform);
                    ammo -= 1;
                }
            }
            Instantiate(firePrefab, spawn1.transform);
            GetComponent<AudioSource>().PlayOneShot(myshot);
            ammo -= 1;
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


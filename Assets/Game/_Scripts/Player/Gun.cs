using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public int ammo;
    public Text txtAmmo;
    public GameObject spawn1, spawn2, firePrefab;
    public AudioClip myshot;
    public float fireRate;
    private float _nextFire;
    private bool b;


    private InputManager inputManager;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
    }
    void Update()
    {
        txtAmmo.text = $"Ammo {ammo}";

        if (inputManager.isShooting && Time.time > _nextFire) {
            Fire();
        }


        if (ammo <= 25)
        {
            if (!b)
                StartCoroutine(Fade());
        }
        else
        {
            Color temp = txtAmmo.color;
            temp.a = 1;
            txtAmmo.color = temp;
        }
    }

    public void Fire()
    {
        if (ammo >= 1)
        {
            if (ammo >= 2)
            {
                if (spawn2.active)
                {
                    Instantiate(firePrefab, spawn2.transform);
                    ammo--;
                }
            }

            _nextFire = Time.time + fireRate;
            Instantiate(firePrefab, spawn1.transform);
            GetComponent<AudioSource>().PlayOneShot(myshot);
            ammo--;
        }
    }

    IEnumerator Fade()
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

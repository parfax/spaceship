using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class SkyTanker : MonoBehaviour {
    public int ammo, hp = 100;
    public Text txtAmmo;

    public Vector2 xx, yy;
    public Slider sldr;
    public GameObject spawn1, spawn2, firePrefab, Gorit, explosion, gameEnd;
    public bool isGorit;
    public AudioClip myshot;
    public bool b, isShooting;

    public float fireRate;


    [SerializeField]
    private InputActionReference attack;


    private void OnEnable()
    {
        attack.action.performed += ctx => isShooting = true;
        attack.action.canceled += ctx => isShooting = false;
    }
    private void OnDisable()
    {
        attack.action.performed -= PerformAttack;
    }

    #region Mono

    private void Update()
    {
        txtAmmo.text = "Ammo " + ammo;

        if (isGorit)
        {
            Gorit.SetActive(true);
            isGorit = false;
        }
        sldr.value = hp;

        // Separate class

        // Shooting
        if (isShooting) StartCoroutine(Shoot());




        if (transform.position.x >= 7)
        {
            transform.position = xx;
        }
        if (transform.position.x <= -7)
        {
            transform.position = yy;
        }


        // Separate class
        if (hp <= 0)
        {
            hp = 0;
            explosion.transform.position = transform.position;
            Instantiate(explosion);
            gameEnd.SetActive(true);
            Destroy(gameObject);
        }



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
    }

    #endregion


    private void PerformAttack(InputAction.CallbackContext obj)
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        

        if (ammo >= 1 && isShooting)
        {
            if (ammo >= 2)
            {
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
        isShooting = false;

        yield return new WaitForSeconds(1f / (fireRate / 60f));
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

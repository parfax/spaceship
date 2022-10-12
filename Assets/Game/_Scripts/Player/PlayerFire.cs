using UnityEngine;

public class PlayerFire : MonoBehaviour {
    Rigidbody2D rb;
    public AudioClip babax;
    public GameObject goritEnemy;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    void FixedUpdate()
    {
        rb.AddForce(new Vector2(0, 500), ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "enemy" && col.gameObject.GetComponent<boss>())
        {
            col.gameObject.GetComponent<boss>().hp -= 50;
            Instantiate(goritEnemy, col.gameObject.transform);
            GetComponent<AudioSource>().PlayOneShot(babax);
        }
        if (col.tag == "enemy")
        {
            col.gameObject.GetComponent<enemy>().hp -= 50;
            Instantiate(goritEnemy, col.gameObject.transform);
            GetComponent<AudioSource>().PlayOneShot(babax);
        }
        if (col.tag == "firen")
        {
            col.gameObject.GetComponent<stoneHP>().hp -= 50;
            Instantiate(goritEnemy, col.gameObject.transform);
            GetComponent<AudioSource>().PlayOneShot(babax);
        }
    }
}

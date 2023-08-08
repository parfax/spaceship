using UnityEngine;
using UnityEngine.UI;

public class boss : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float speed;
    [SerializeField] private Vector2 yy;
    [SerializeField] private Vector2 yy1;

    public int hp;
    public Text hptxt;
    [SerializeField] private AudioClip enemShot;

    [SerializeField] private Slider healthSlider;

    [SerializeField] private GameObject spawn1, spawn2, spawn3, spawn4;
    [SerializeField] private GameObject fire, explosion;

    private float TimeStart;
    [SerializeField] private float TimeEnd, TimeSpeed = 1f;

    // Use this for initialization
    void Start()
    {
        healthSlider.maxValue = hp;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        HandleHealth();
        Shoot();        
    }

    private void HandleHealth()
    {
        healthSlider.value = hp;

        if (hp <= 0)
        {
            hp = 0;
            GameObject.FindGameObjectWithTag("spwnMngr").GetComponent<SpawnMngr>().isBoss = false;
            explosion.transform.position = transform.position;
            Instantiate(explosion);
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        yy = new Vector2(target.position.x, yy1.y);
        transform.position = Vector2.MoveTowards(transform.position, yy, speed * Time.deltaTime);
    }

    private void Shoot()
    {
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
    }
}
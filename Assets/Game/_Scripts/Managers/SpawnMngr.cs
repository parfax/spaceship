using UnityEngine;
using UnityEngine.Audio;

public class SpawnMngr : MonoBehaviour
{
    [SerializeField] private AudioMixer astandard;

    [SerializeField] private GameObject boss1, boss2, boss3, auStart, boss, aggresive, enemyFire, enemyPrefab, med, ammoCase;
    public bool isBoss;


    [SerializeField] private int TimeEnd, TimeSpeed = 1, TimeRecord, dropTimeEnd, dropRandom;
    private int TimeStart, dropTimeStart, randomIndex;
    [SerializeField] private RecordSynchronizer record;
    [SerializeField] private Color[] colors;
    [SerializeField] private Transform[] SpawnPoints;
    [SerializeField] private GameObject[] stonePrefabs;
    private Rigidbody2D fireRb;

    // Use this for initialization
    private void Start()
    {
        astandard.SetFloat("volume", 10);
        fireRb = enemyFire.GetComponent<Rigidbody2D>();
    }
    private void BonusAmmo()
    {
        var r = Random.Range(0, 3);
        Instantiate(ammoCase, SpawnPoints[r]);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (isBoss)
        {
            TimeStart = 0;
            auStart.SetActive(false);
            boss.SetActive(true);
            aggresive.SetActive(false);
        }

        switch (TimeRecord)
        {
            case 5000:
                isBoss = true;
                astandard.SetFloat("volume", 0);
                Instantiate(boss1, SpawnPoints[2]);
                BonusAmmo();
                break;

            case 9000:
                isBoss = true;
                Instantiate(boss2, SpawnPoints[2]);
                BonusAmmo();
                break;

            case 12000:
                isBoss = true;
                Instantiate(boss3, SpawnPoints[2]);
                BonusAmmo();
                break;
        }



        record.curRec = TimeRecord;
        TimeRecord += TimeSpeed;
        dropTimeStart += TimeSpeed;

        if (dropTimeStart >= dropTimeEnd)
        {
            dropRandom = Random.Range(0, 3);
            int r = Random.Range(0, 10);
            int rr = Random.Range(0, 3);

            Instantiate(stonePrefabs[r], SpawnPoints[rr].transform);

            switch (dropRandom) { 
                case 1:
                    Instantiate(med, SpawnPoints[rr]);
                    break;

                case 2:
                    BonusAmmo();
                    break;

                case 3:
                    Instantiate(stonePrefabs[r], SpawnPoints[rr]);
                    break;
            }
            dropTimeStart = 0;
        }

        if (TimeRecord >= 0 && TimeRecord < 1200)
        {
            fireRb.gravityScale = 1f;
            TimeEnd = 300;
            Time.timeScale = 1f;
            Variant1();
        }
        if (TimeRecord > 1200 && TimeRecord < 1800)
        {
            fireRb.gravityScale = 2f;
            TimeEnd = 300;
            Time.timeScale = 1f;
            Variant1();
        }
        if (TimeRecord > 1800 && TimeRecord < 2100)
        {
            fireRb.gravityScale = 2f;
            TimeEnd = 250;
            Time.timeScale = 1.2f;
            Variant1();
        }
        if (TimeRecord > 2100 && TimeRecord < 2400)
        {
            fireRb.gravityScale = 2f;
            TimeEnd = 200;
            Time.timeScale = 1.4f;
            Variant1();
        }
        if (TimeRecord > 2400 && TimeRecord < 3000)
        {
            fireRb.gravityScale = 2f;
            TimeEnd = 180;
            Time.timeScale = 1.6f;
            Variant1();
        }
        if (TimeRecord > 3000 && TimeRecord < 4000)
        {
            fireRb.gravityScale = 2f;
            TimeEnd = 150;
            Time.timeScale = 1.8f;
            Variant1();
        }
        if (TimeRecord > 4000 && TimeRecord < 5000)
        {
            fireRb.gravityScale = 2f;
            TimeEnd = 180;
            Time.timeScale = 2f;
            Variant1();
        }
        if (TimeRecord > 5000 && TimeRecord < 7000)
        {
            fireRb.gravityScale = 2f;
            TimeEnd = 130;
            Time.timeScale = 2.2f;
            Variant1();
        }
        if (TimeRecord > 7000 && TimeRecord < 8000)
        {
            fireRb.gravityScale = 3f;
            TimeEnd = 100;
            Time.timeScale = 2.4f;
            Variant2();
        }
        if (TimeRecord > 8000 && TimeRecord < 9000)
        {
            fireRb.gravityScale = 3f;
            TimeEnd = 100;
            Time.timeScale = 2.6f;
            Variant2();
        }
        if (TimeRecord > 9000 && TimeRecord < 10000)
        {
            fireRb.gravityScale = 3f;
            TimeEnd = 60;
            Time.timeScale = 2.8f;
            Variant2();
        }
        if (TimeRecord > 10000 && TimeRecord < 12000)
        {
            fireRb.gravityScale = 4f;
            TimeEnd = 30;
            Time.timeScale = 3f;
            Variant2();
        }
        if (TimeRecord > 12000)
        {
            fireRb.gravityScale = 5f;
            TimeEnd = 180;
            Time.timeScale = 4f;
            Variant2();
        }

        TimeStart += TimeSpeed;
        if (TimeStart >= TimeEnd)
        {
            randomIndex = Random.Range(0, 5);
            enemyPrefab.GetComponent<SpriteRenderer>().color = colors[randomIndex];
            randomIndex = Random.Range(0, 5);
            TimeStart = 0;
        }
        Instantiate(enemyPrefab, SpawnPoints[randomIndex]);
    }

    private void Variant1()
    {
        if (!isBoss)
        {
            auStart.SetActive(true);
            boss.SetActive(false);
            aggresive.SetActive(false);
        }
    }
    private void Variant2()
    {
        if (!isBoss)
        {
            auStart.SetActive(false);
            boss.SetActive(false);
            aggresive.SetActive(true);
        }
    }
}
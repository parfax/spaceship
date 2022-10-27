using UnityEngine;
using UnityEngine.Audio;

public class SpawnMngr : MonoBehaviour
{
    public AudioMixer astandard;

    public GameObject boss1, boss2, boss3, auStart, boss, aggresive, enemyFire, enem, med, ammoCase, rcrd;
    public bool isBoss;

    public Color e1, e2, e3, e4;

    public int spawnRandom, TimeStart, TimeEnd, TimeSpeed = 1, TimeRecord, dropTimeStart, dropTimeEnd, dropRandom, SpawnDropRandom;
    public Transform[] SpawnPoints;
    public GameObject[] stones;

    // Use this for initialization
    void Start()
    {
        astandard.SetFloat("volume", 10);
    }
    void BonusAmmo()
    {
        var r = Random.Range(0, 3);
        Instantiate(ammoCase, SpawnPoints[r]);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (isBoss)
        {
            TimeStart = 0;
            auStart.SetActive(false);
            boss.SetActive(true);
            aggresive.SetActive(false);
        }

        if (TimeRecord == 5000)
        {
            isBoss = true;
            astandard.SetFloat("volume", 0);
            Instantiate(boss1, SpawnPoints[2]);
            BonusAmmo();
        }
        if (TimeRecord == 9000)
        {
            isBoss = true;
            Instantiate(boss2, SpawnPoints[2]);
            BonusAmmo();
        }
        if (TimeRecord == 12000)
        {
            isBoss = true;
            Instantiate(boss3, SpawnPoints[2]);
            BonusAmmo();
        }



        rcrd.GetComponent<record>().curRec = TimeRecord;
        TimeRecord += TimeSpeed;
        dropTimeStart += TimeSpeed;

        if (dropTimeStart >= dropTimeEnd)
        {
            dropRandom = Random.Range(0, 3);
            int r = Random.Range(0, 10);
            int rr = Random.Range(0, 3);

            Instantiate(stones[r], SpawnPoints[rr].transform);

            if (dropRandom == 1)
            {
                Instantiate(med, SpawnPoints[rr]);
            }
            if (dropRandom == 2)
            {
                BonusAmmo();
            }
            if (dropRandom == 3)
            {
                Instantiate(stones[r], SpawnPoints[rr]);
            }
            SpawnDropRandom = 0;
            dropTimeStart = 0;
        }

        if (TimeRecord >= 0 && TimeRecord < 1200)
        {
            enemyFire.GetComponent<Rigidbody2D>().gravityScale = 1f;
            TimeEnd = 300;
            Time.timeScale = 1f;
            if (!isBoss)
            {
                auStart.SetActive(true);
                boss.SetActive(false);
                aggresive.SetActive(false);
            }
        }
        if (TimeRecord > 1200 && TimeRecord < 1800)
        {
            enemyFire.GetComponent<Rigidbody2D>().gravityScale = 2f;
            TimeEnd = 300;
            Time.timeScale = 1f;
            if (!isBoss)
            {
                auStart.SetActive(true);
                boss.SetActive(false);
                aggresive.SetActive(false);
            }
        }
        if (TimeRecord > 1800 && TimeRecord < 2100)
        {
            enemyFire.GetComponent<Rigidbody2D>().gravityScale = 2f;
            TimeEnd = 250;
            Time.timeScale = 1.2f;
            if (!isBoss)
            {
                auStart.SetActive(true);
                boss.SetActive(false);
                aggresive.SetActive(false);
            }
        }
        if (TimeRecord > 2100 && TimeRecord < 2400)
        {
            enemyFire.GetComponent<Rigidbody2D>().gravityScale = 2f;
            TimeEnd = 200;
            Time.timeScale = 1.4f;
            if (!isBoss)
            {
                auStart.SetActive(true);
                boss.SetActive(false);
                aggresive.SetActive(false);
            }
        }
        if (TimeRecord > 2400 && TimeRecord < 3000)
        {
            enemyFire.GetComponent<Rigidbody2D>().gravityScale = 2f;
            TimeEnd = 180;
            Time.timeScale = 1.6f;
            if (!isBoss)
            {
                auStart.SetActive(true);
                boss.SetActive(false);
                aggresive.SetActive(false);
            }
        }
        if (TimeRecord > 3000 && TimeRecord < 4000)
        {
            enemyFire.GetComponent<Rigidbody2D>().gravityScale = 2f;
            TimeEnd = 150;
            Time.timeScale = 1.8f;
            if (!isBoss)
            {
                auStart.SetActive(true);
                boss.SetActive(false);
                aggresive.SetActive(false);
            }
        }
        if (TimeRecord > 4000 && TimeRecord < 5000)
        {
            enemyFire.GetComponent<Rigidbody2D>().gravityScale = 2f;
            TimeEnd = 180;
            Time.timeScale = 2f;
            if (!isBoss)
            {
                auStart.SetActive(true);
                boss.SetActive(false);
                aggresive.SetActive(false);
            }
        }
        if (TimeRecord > 5000 && TimeRecord < 7000)
        {
            enemyFire.GetComponent<Rigidbody2D>().gravityScale = 2f;
            TimeEnd = 130;
            Time.timeScale = 2.2f;
            if (!isBoss)
            {
                auStart.SetActive(true);
                boss.SetActive(false);
                aggresive.SetActive(false);
            }
        }
        if (TimeRecord > 7000 && TimeRecord < 8000)
        {
            enemyFire.GetComponent<Rigidbody2D>().gravityScale = 3f;
            TimeEnd = 100;
            Time.timeScale = 2.4f;
            if (!isBoss)
            {
                auStart.SetActive(false);
                boss.SetActive(false);
                aggresive.SetActive(true);
            }
        }
        if (TimeRecord > 8000 && TimeRecord < 9000)
        {
            enemyFire.GetComponent<Rigidbody2D>().gravityScale = 3f;
            TimeEnd = 100;
            Time.timeScale = 2.6f;
            if (!isBoss)
            {
                auStart.SetActive(false);
                boss.SetActive(false);
                aggresive.SetActive(true);
            }
        }
        if (TimeRecord > 9000 && TimeRecord < 10000)
        {
            enemyFire.GetComponent<Rigidbody2D>().gravityScale = 3f;
            TimeEnd = 60;
            Time.timeScale = 2.8f;
            if (!isBoss)
            {
                auStart.SetActive(false);
                boss.SetActive(false);
                aggresive.SetActive(true);
            }
        }
        if (TimeRecord > 10000 && TimeRecord < 12000)
        {
            enemyFire.GetComponent<Rigidbody2D>().gravityScale = 4f;
            TimeEnd = 30;
            Time.timeScale = 3f;
            if (!isBoss)
            {
                auStart.SetActive(false);
                boss.SetActive(false);
                aggresive.SetActive(true);
            }
        }
        if (TimeRecord > 12000)
        {
            enemyFire.GetComponent<Rigidbody2D>().gravityScale = 5f;
            TimeEnd = 180;
            Time.timeScale = 4f;
            if (!isBoss)
            {
                auStart.SetActive(false);
                boss.SetActive(false);
                aggresive.SetActive(true);
            }
        }
        TimeStart += TimeSpeed;
        if (TimeStart >= TimeEnd)
        {
            spawnRandom = Random.Range(1, 6);
            int rr = Random.Range(1, 5);
            if (rr == 1)
                enem.GetComponent<SpriteRenderer>().color = e1;
            if (rr == 2)
                enem.GetComponent<SpriteRenderer>().color = e2;
            if (rr == 3)
                enem.GetComponent<SpriteRenderer>().color = e3;
            if (rr == 4)
                enem.GetComponent<SpriteRenderer>().color = e4;
            TimeStart = 0;
        }

        if (spawnRandom == 1)
        {
            Instantiate(enem, SpawnPoints[0]);
            spawnRandom = 0;
        }
        if (spawnRandom == 2)
        {
            Instantiate(enem, SpawnPoints[1]);
            spawnRandom = 0;
        }
        if (spawnRandom == 3)
        {
            Instantiate(enem, SpawnPoints[2]);
            spawnRandom = 0;
        }
        if (spawnRandom == 4)
        {
            Instantiate(enem, SpawnPoints[3]);
            spawnRandom = 0;
        }
        if (spawnRandom == 5)
        {
            Instantiate(enem, SpawnPoints[4]);
            spawnRandom = 0;
        }
    }
}
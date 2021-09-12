using UnityEngine;
using UnityEngine.Audio;

public class SpawnMngr : MonoBehaviour
{
    public AudioMixer astandard;

    public GameObject boss1, boss2, boss3, auStart, boss, aggresive, enemyFire, enem, med, ammoCase, rcrd, stone1, stone2, stone3, stone4, stone5;
    public bool isBoss;

    public Color e1, e2, e3, e4;

    public int spawnRandom, TimeStart, TimeEnd,TimeSpeed = 1, TimeRecord, dropTimeStart, dropTimeEnd, dropRandom, SpawnDropRandom;
    public Transform Spawn1, Spawn2,Spawn3, Spawn4, Spawn5;

    // Use this for initialization
    void Start () {
        astandard.SetFloat("volume", 20);
    }
	void BonusAmmo()
    {
        SpawnDropRandom = Random.Range(1, 4);
        if (SpawnDropRandom == 1)
        {
            Instantiate(ammoCase, Spawn1.transform);
            SpawnDropRandom = 0;
        }
        if (SpawnDropRandom == 2)
        {
            Instantiate(ammoCase, Spawn2.transform);
            SpawnDropRandom = 0;
        }
        if (SpawnDropRandom == 4)
        {
            Instantiate(ammoCase, Spawn4.transform);
            SpawnDropRandom = 0;
        }
    }
	// Update is called once per frame
	void FixedUpdate () {
        if (isBoss)
        {
            TimeStart = 0;
            auStart.SetActive(false);
            boss.SetActive(true);
            aggresive.SetActive(false);
        }

        if(TimeRecord == 5000)
        {
            isBoss = true;
            astandard.SetFloat("volume", 0);
            Instantiate(boss1, Spawn1.transform);
            BonusAmmo();
        }
        if (TimeRecord == 9000)
        {
            isBoss = true;
            Instantiate(boss2, Spawn1.transform);
            BonusAmmo();
        }
        if (TimeRecord == 12000)
        {
            isBoss = true;
            Instantiate(boss3, Spawn1.transform);
            BonusAmmo();
        }



        rcrd.GetComponent<record>().curRec = TimeRecord;
        TimeRecord += TimeSpeed;
        dropTimeStart += TimeSpeed;

        if (dropTimeStart >= dropTimeEnd)
        {
            dropRandom = Random.Range(1, 3);
            SpawnDropRandom = Random.Range(1, 4);
            int r = Random.Range(4, 16);
            int rr = Random.Range(1, 4);

            if (r == 11 && rr == 3)
                Instantiate(stone1, Spawn5.transform);
            if (r == 11 && rr == 2)
                Instantiate(stone1, Spawn3.transform);
            if (r == 11 && rr == 1)
                Instantiate(stone1, Spawn1.transform);
            if (r == 12 && rr == 3)
                Instantiate(stone5, Spawn5.transform);
            if (r == 12 && rr == 2)
                Instantiate(stone5, Spawn3.transform);
            if (r == 12 && rr == 1)
                Instantiate(stone5, Spawn1.transform);
            if (r == 13 && rr == 3)
                Instantiate(stone4, Spawn5.transform);
            if (r == 13 && rr == 2)
                Instantiate(stone4, Spawn3.transform);
            if (r == 13 && rr == 1)
                Instantiate(stone4, Spawn1.transform);
            if (r == 14 && rr == 3)
                Instantiate(stone3, Spawn5.transform);
            if (r == 14 && rr == 2)
                Instantiate(stone3, Spawn3.transform);
            if (r==14&&rr==1)
                Instantiate(stone3, Spawn1.transform);
            if(r==15&&rr==3)
                Instantiate(stone2, Spawn5.transform);
            if(r==15&&rr==2)
                Instantiate(stone2, Spawn3.transform);
            if(r==15&&rr==1)
                Instantiate(stone2, Spawn1.transform);
            if (dropRandom == 1)
            {
                if(SpawnDropRandom == 1)
                    Instantiate(med, Spawn1.transform);

                if (SpawnDropRandom == 2)
                    Instantiate(med, Spawn2.transform);

                if (SpawnDropRandom == 4)
                    Instantiate(med, Spawn4.transform);
            }
            if(dropRandom == 2)
            {
                if (SpawnDropRandom == 1)
                    Instantiate(ammoCase, Spawn1.transform);

                if (SpawnDropRandom == 2)
                    Instantiate(ammoCase, Spawn2.transform);

                if (SpawnDropRandom == 4)
                    Instantiate(ammoCase, Spawn4.transform);
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
            TimeEnd = 20;
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
            if(rr == 1)
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
                Instantiate(enem, Spawn1.transform);
                spawnRandom = 0;
        }
        if (spawnRandom == 2)
        {
                Instantiate(enem, Spawn2.transform);
                spawnRandom = 0;
        }
        if (spawnRandom == 3)
        {
                Instantiate(enem, Spawn3.transform);
                spawnRandom = 0;
        }
        if (spawnRandom == 4)
        {
                Instantiate(enem, Spawn4.transform);
                spawnRandom = 0;
        }
        if (spawnRandom == 5)
        {
                Instantiate(enem, Spawn5.transform);
                spawnRandom = 0;
        }
    }
}
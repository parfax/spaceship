using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {
    public AudioClip babax;
    public int d;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            col.gameObject.GetComponent<SkyTanker>().hp -= d;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>().SetTrigger("damage");
            col.gameObject.GetComponent<SkyTanker>().isGorit = true;
            GetComponent<AudioSource>().PlayOneShot(babax);
            Destroy(gameObject);
        }
    }
}

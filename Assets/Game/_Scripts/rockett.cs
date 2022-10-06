using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockett : MonoBehaviour {
    public AudioClip babax;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            col.gameObject.GetComponent<SkyTanker>().hp -= 40;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>().SetTrigger("damage");
            col.gameObject.GetComponent<SkyTanker>().isGorit = true;
            GetComponent<AudioSource>().PlayOneShot(babax);
        }
    }
}

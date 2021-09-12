using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medkit : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            col.gameObject.GetComponent<SkyTanker>().hp += 10;
            Destroy(gameObject);
        }
    }
}

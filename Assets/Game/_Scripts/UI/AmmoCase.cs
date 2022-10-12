using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoCase : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            col.gameObject.GetComponent<SkyTanker>().ammo += 100;
            Destroy(gameObject);
        }
    }
}

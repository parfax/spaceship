using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "firen")
            Destroy(col.gameObject);
        if (col.tag == "enemy")
            Destroy(col.gameObject);
    }
}

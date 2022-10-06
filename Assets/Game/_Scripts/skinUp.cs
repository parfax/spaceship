using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinUp : MonoBehaviour
{
    public Transform target,self;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, 100);
        if (hitInfo)
        {
            if (hitInfo.collider.tag == "skin")
            {
                target = hitInfo.collider.gameObject.transform;
                if (Vector3.Distance(transform.position, target.position) > 4.5f)
                    self.localPosition += Vector3.up * 5;
            }
        }
    }
}

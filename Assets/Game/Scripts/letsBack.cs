using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letsBack : MonoBehaviour
{
    public GameObject more;
    public void backk()
    {
        more.SetActive(true);
        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letsBackToShop : MonoBehaviour
{
    public GameObject shop;

    public void backk()
    {
        shop.SetActive(true);
        gameObject.SetActive(false);
    }
}

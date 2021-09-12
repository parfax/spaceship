using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class movementt : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isLeft;
    public GameObject playerr;
	// Use this for initialization
	void Update () {
        if (isLeft)
        {
            playerr.GetComponent<SkyTanker>().speed -= playerr.GetComponent<SkyTanker>().speedHor;
        }
	}

    // Update is called once per frame
    public void OnPointerDown(PointerEventData eventData)
    {
        isLeft = true;
    }
    public void OnPointerUp (PointerEventData eventData) {
        isLeft = false;
    }
}

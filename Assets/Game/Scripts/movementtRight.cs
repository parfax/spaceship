using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class movementtRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isRight;
    public GameObject playerr;
    // Use this for initialization
    void Update()
    {
        if (isRight)
        {
            playerr.GetComponent<SkyTanker>().speed = playerr.GetComponent<SkyTanker>().speedHor;
        }
    }

    // Update is called once per frame
    public void OnPointerDown(PointerEventData eventData)
    {
        isRight = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isRight = false;
    }
}

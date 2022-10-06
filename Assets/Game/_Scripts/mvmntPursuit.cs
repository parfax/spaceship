using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class mvmntPursuit : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public SkyTankerPursuit skyTanker;
    public bool isLeft;

    public void OnPointerDown(PointerEventData eventData)
    {
        if(isLeft)
          skyTanker.isLeft = true;
        else
            skyTanker.isRight = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if (isLeft)
            skyTanker.isLeft = false;
        else
            skyTanker.isRight = false;
    }
}

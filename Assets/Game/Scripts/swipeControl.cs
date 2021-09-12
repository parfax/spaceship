using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class swipeControl : MonoBehaviour, IDragHandler {
    public Transform menuu;
    public GameObject swipe;
    public void OnDrag(PointerEventData eventData)
    {
        swipe.SetActive(false);
        if (eventData.delta.x > 0)
        {
            if (menuu.localPosition.x == -540f)
                StartCoroutine(rgt());
        }

        if(eventData.delta.x < 0)
        {
            if (menuu.position.x == 0f)
                StartCoroutine(lft());
        }
    }
    IEnumerator lft()
    {
            for (int i = 54; i > 0; i--)
            {
                menuu.transform.localPosition += Vector3.left * 10;
                yield return new WaitForSeconds(.01f);
            }
    }
    IEnumerator rgt()
    {
        for (int i = 54; i > 0; i--)
        {
                menuu.transform.localPosition += Vector3.right * 10;
                yield return new WaitForSeconds(.01f);
        }
    }
}

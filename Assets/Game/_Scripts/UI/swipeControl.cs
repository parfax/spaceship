using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class swipeControl : MonoBehaviour, IDragHandler {
    public Transform menu;
    public GameObject swipe;
    public GameObject[] buttons;
    
    private void Update()
    {
        if(EventSystem.current.currentSelectedGameObject == buttons[1])
        {
            if (menu.position.x == 0f)
                StartCoroutine(lft());
        }
        else if(EventSystem.current.currentSelectedGameObject == buttons[0])
        {
            if (menu.position.x == -540f)
                StartCoroutine(rgt());
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        swipe.SetActive(false);
        if (eventData.delta.x > 0)
        {
            if (menu.localPosition.x == -540f)
                StartCoroutine(rgt());
        }

        if (!(eventData.delta.x < 0)) return;
        if (menu.position.x == 0f)
            StartCoroutine(lft());
    }
    private IEnumerator lft()
    {
            for (var i = 54; i > 0; i--)
            {
                menu.transform.localPosition += Vector3.left * 10;
                yield return new WaitForSeconds(.007f);
            }
    }
    private IEnumerator rgt()
    {
        for (var i = 54; i > 0; i--)
        {
                menu.transform.localPosition += Vector3.right * 10;
                yield return new WaitForSeconds(.007f);
        }
    }
}

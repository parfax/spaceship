using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class editButton : MonoBehaviour, IDragHandler
{
    public int hidden;
    public GameObject surePanel, anotherBtn;
    public Vector2 p;
    public Toggle sync;
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (sync.isOn)
        {
            Vector2 a;
            a.x = -transform.position.x;
            a.y = transform.position.y;
            anotherBtn.transform.position = a;
        }
    }
    void Update()
    {
        p = transform.position;
    }
    public void openHidden()
    {
        surePanel.SetActive(true);
    }
    public void PlusHidden()
    {
        hidden = 1;
        surePanel.SetActive(false);
    }
    public void MinusHidden()
    {
        surePanel.SetActive(false);
    }
}
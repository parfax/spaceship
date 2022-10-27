using UnityEngine;

public class AmmoCase : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            col.gameObject.GetComponent<Gun>().ammo += 100;
            Destroy(gameObject);
        }
    }
}

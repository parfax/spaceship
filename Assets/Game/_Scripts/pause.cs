using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    public SpawnMngr spawnMngr;
    public record record;
    public GameObject panel;
    public Text txt;
    int a;
    bool b;
    

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (!b) return;
        
        a--;
        if (a == 180)
            txt.text = "3";
        if (a == 120)
            txt.text = "2";
        if (a == 60)
            txt.text = "1";

        
        if (a > 0) return;
        Time.timeScale = 1f;
        spawnMngr.enabled = true;
        record.enabled = true;
        b = false;
        txt.gameObject.SetActive(false);
    }
    public void Pausen()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
        spawnMngr.enabled = false;
        record.enabled = false;
    }
    public void Continnue()
    {
        panel.SetActive(false);
        a = 181;
        txt.gameObject.SetActive(true);
        b = true;
    }
    public void reqMain(GameObject panel)
    {
        panel.SetActive(true);
    }
    public void fakeMain(GameObject panel)
    {
        panel.SetActive(false);
    }
    public void goMain()
    {
        Application.LoadLevel("Main");
    }
}

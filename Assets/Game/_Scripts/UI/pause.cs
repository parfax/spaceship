using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class pause : MonoBehaviour
{
    public SpawnMngr spawnMngr;
    public record record;
    public GameObject panel;
    public Text txt;
    int a;
    bool b, isPaused;
    

    // Update is called once per frame
    private void Update()
    {
        if (b)
        {
            a--;
            if (a == 180)
                txt.text = "3";
            if (a == 120)
                txt.text = "2";
            if (a == 60)
                txt.text = "1";

            if (a <= 0)
            {
                Time.timeScale = 1f;
                spawnMngr.enabled = true;
                record.enabled = true;
                b = false;
                txt.gameObject.SetActive(false);
            }
        }
    }

    public void OnPause(InputAction.CallbackContext ctx) {
        if (!ctx.performed) return;

        isPaused = !isPaused;

        if (isPaused) Pause();
        else Continnue();
    } 

    private void Pause()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
        spawnMngr.enabled = false;
        record.enabled = false;
    }
    private void Continnue()
    {
        isPaused = false;
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

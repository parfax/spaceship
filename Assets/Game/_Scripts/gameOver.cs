using UnityEngine;

public class gameOver : MonoBehaviour {
    public float TimeDieStart, TimeDieEnd, TimeDieSpeed = 1f;
    public GameObject spwnmang, retryPanel, recPanel;

    // Update is called once per frame
    void FixedUpdate () {
        spwnmang.SetActive(false);
        TimeDieStart += TimeDieSpeed;
        
        if (!(TimeDieStart >= TimeDieEnd)) return;
        Time.timeScale = 0f;
        recPanel.SetActive(false);
        retryPanel.SetActive(true);
    }
}

using UnityEngine;

public class gameOver : MonoBehaviour {
    private float TimeDieStart;
    [SerializeField] private float TimeDieEnd, TimeDieSpeed = 1f;
    [SerializeField] private GameObject spwnmang, retryPanel, recPanel;

    // Update is called once per frame
    private void FixedUpdate () {
        spwnmang.SetActive(false);
        TimeDieStart += TimeDieSpeed;
        
        if (!(TimeDieStart >= TimeDieEnd)) return;
        Time.timeScale = 0f;
        recPanel.SetActive(false);
        retryPanel.SetActive(true);
    }
}

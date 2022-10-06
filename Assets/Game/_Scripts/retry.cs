using UnityEngine;
using UnityEngine.SceneManagement;

public class retry : MonoBehaviour {
	public void rretry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }
}

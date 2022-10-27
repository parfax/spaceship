using UnityEngine;
using UnityEngine.UI;

public class SkyTanker : MonoBehaviour {
    public int hp = 100;

    public Vector2 xx, yy;
    public Slider sldr;
    public GameObject Gorit, explosion, gameEnd;
    public bool isGorit;


    #region Mono

    private void Update()
    {

        if (isGorit)
        {
            Gorit.SetActive(true);
            isGorit = false;
        }
        sldr.value = hp;

        if (transform.position.x >= 7)
        {
            transform.position = xx;
        }
        if (transform.position.x <= -7)
        {
            transform.position = yy;
        }


        // Separate class
        if (hp <= 0)
        {
            hp = 0;
            explosion.transform.position = transform.position;
            Instantiate(explosion);
            gameEnd.SetActive(true);
            Destroy(gameObject);
        }        
    }

    #endregion
}

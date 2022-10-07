using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.PostProcessing;

namespace Game.Scripts
{
    public class PreservationSystem : MonoBehaviour { // Make static class
        public GameObject btnLeftPos,
            btnRightPos, btnAttack1Pos,
            btnAttack2Pos;

        public GameObject player;
        public GameObject secondGun;
        private static Sprite[] allSkins;
        public static List<(Sprite, int)> availableSkins = new List<(Sprite, int)>();
        
        private void Start () {
            Camera.main.GetComponent<PostProcessingBehaviour>().enabled = PlayerPrefs.GetInt("PostProcessing") == 0;
            Vector2 ll, rr, aa1, aa2;
            ll.x = PlayerPrefs.GetFloat("btnLeftPosX");
            ll.y = PlayerPrefs.GetFloat("btnLeftPosY");
            rr.x = PlayerPrefs.GetFloat("btnRightPosX");
            rr.y = PlayerPrefs.GetFloat("btnRightPosY");
            aa1.x = PlayerPrefs.GetFloat("btnAttack1PosX");
            aa1.y = PlayerPrefs.GetFloat("btnAttack1PosY");
            aa2.x = PlayerPrefs.GetFloat("btnAttack2PosX");
            aa2.y = PlayerPrefs.GetFloat("btnAttack2PosY");
            btnLeftPos.transform.position = ll;
            btnRightPos.transform.position = rr;
            btnAttack1Pos.transform.position = aa1;
            btnAttack2Pos.transform.position = aa2;
        
            btnAttack1Pos.SetActive(PlayerPrefs.GetInt("btnAttack1Hidden") == 0);
            btnAttack2Pos.SetActive(PlayerPrefs.GetInt("btnAttack2Hidden") == 0);

            LoadSkins();
            player.GetComponent<SpriteRenderer>().sprite = allSkins[PlayerPrefs.GetInt("Selected Skin")];
            player.GetComponent<SkyTanker>().hp = PlayerPrefs.GetInt("Max Health");

            secondGun.SetActive(PlayerPrefs.GetInt("Gun Type") == 1);
        }

        public static void LoadSkins()
        {
            if (!PlayerPrefs.HasKey("Selected Skin")) PlayerPrefs.SetInt("Selected Skin", 0);
            if (!PlayerPrefs.HasKey("skin0")) PlayerPrefs.SetString("skin0", "");
            
            allSkins = Resources.LoadAll<Sprite>("Skins");
        }

        public static void GetAvailableSkins()
        {
            for (int i = 0; i < allSkins.Length; i++)
            {
                if (PlayerPrefs.HasKey($"skin{i}"))
                {
                    availableSkins.Add((allSkins[i], i));
                }
            }
        }
    }
}

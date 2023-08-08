using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts
{
    public class PreservationSystem : MonoBehaviour { // Make static class
        [SerializeField] private GameObject btnLeftPos,
            btnRightPos, btnAttack1Pos,
            btnAttack2Pos;

        [SerializeField] private GameObject player, secondGun;
        private static SkinData[] allSkins;
        private static List<(SkinData, int)> availableSkins;
        
        private void Start () {
            // Camera.main.GetComponent<PostProcessingBehaviour>().enabled = PlayerPrefs.GetInt("PostProcessing") == 0;
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
            player.GetComponent<SpriteRenderer>().sprite = allSkins[PlayerPrefs.GetInt("Selected Skin")].sprite;
            player.GetComponent<SkyTanker>().hp = PlayerPrefs.GetInt("Max Health");

            if (!PlayerPrefs.HasKey("Ammo")) PlayerPrefs.SetInt("Ammo", 100);
            player.GetComponent<Gun>().ammo = PlayerPrefs.GetInt("Ammo");

            secondGun.SetActive(PlayerPrefs.GetInt("Gun Type") == 1);
        }

        public static void LoadSkins()
        {
            if (!PlayerPrefs.HasKey("Selected Skin")) PlayerPrefs.SetInt("Selected Skin", 0);
            if (!PlayerPrefs.HasKey("skin0")) PlayerPrefs.SetString("skin0", "");
            
            allSkins = Resources.LoadAll<SkinData>("Skins/Assets");
        }

        public static SkinData GetSkin(int index) => allSkins[index];

        public static List<(SkinData, int)> GetAvailableSkins()
        {
            availableSkins = new List<(SkinData, int)>();
            for (int i = 0; i < allSkins.Length; i++)
                if (PlayerPrefs.HasKey($"skin{i}")) availableSkins.Add((allSkins[i], i));

            return availableSkins;
        }
    }
}

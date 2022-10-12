using UnityEngine;

[CreateAssetMenu(fileName = "New Skin", menuName = "Skin")]
public class SkinData : ScriptableObject
{
    public Sprite sprite;
    public string name;
    public int price;
}

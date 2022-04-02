using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class shopItemSO : ScriptableObject
{
    public int cost = 10, identityVal;
    public bool locked = true;//must buy if true, can be equiped if false
    public bool equipped = false;
    public Sprite mySprite;
    public string myType;
    public Text myText;
}
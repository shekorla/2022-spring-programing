using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class shopItemSO : ScriptableObject
{
    public int cost = 10, identityVal;
    public bool locked = true;//must buy if true, can be equiped if false
    public Sprite mySprite;
    public int  myType; //ball is 1, brick is 2, paddle is 3
    public Vector3 myloc;
}
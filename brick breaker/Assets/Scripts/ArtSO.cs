using UnityEngine;
[CreateAssetMenu]
public class ArtSO : ScriptableObject
{
    public Sprite currentSprite;

    public void changeCurrent(Sprite choice)
    {
        currentSprite = choice;
    }
}

using UnityEditor.UI;
using UnityEngine;
using UnityEngine.Events;

public class PlayrBeh : MonoBehaviour
{
    public UnityEvent StartEv;
    public SpriteRenderer mySpriteR;
    void Start()
    {
        mySpriteR = GetComponentInChildren<SpriteRenderer>();
        StartEv.Invoke();
    }

    public void Config(PlayerScOP newVals)
    {
        mySpriteR.material.color = newVals.myColor;
    }
}

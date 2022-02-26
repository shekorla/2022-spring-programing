using UnityEngine;
using UnityEngine.SceneManagement;
[CreateAssetMenu]
public class changeSprite : ScriptableObject
{
    public ArtSO newArt;
    public GameObject change;

    public void getArt(ArtSO newArt)
    {
        newArt = this.newArt;
    }
    public void getObj(GameObject change)
    {
        change = this.change;
    }
    
    public void changeGiven ()
    {
        change.GetComponentInChildren<SpriteRenderer>().sprite = newArt.currentSprite;
    }
    
    public void LoadLevel(string name){
        SceneManager.LoadScene(name);
    }
}

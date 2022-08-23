using UnityEngine;
using UnityEngine.SceneManagement;
[CreateAssetMenu]
public class changeSprite : ScriptableObject
{
    public ArtSO newArt;
    public GameObject change;

    //yes its rediculous to have three funtions, but it makes it call from the editor
    public void getArt(ArtSO newArt)
    {
        newArt = this.newArt;
    }
    public void getObj(GameObject change)
    {
        change = this.change;
        changeGiven();
    }
    
    public void changeGiven ()
    {
        change.GetComponentInChildren<SpriteRenderer>().sprite = newArt.currentSprite;
    }
    
    public void LoadLevel(string name){
        SceneManager.LoadScene(name);
    }
}

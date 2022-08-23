using UnityEngine;
using UnityEngine.UI;

public class musicManager : MonoBehaviour {
    static musicManager instance = null;

	// Use this for initialization
	void Start () {
        if (instance != null){
            Destroy(gameObject);
        }
        else {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
	}

    public void playClip(AudioClip clip) {
        AudioSource.PlayClipAtPoint(clip, this.transform.position);
        new WaitForSecondsRealtime(2);
    }
    public void volChange(Slider newVol)
    {
        AudioSource music = this.GetComponentInChildren<AudioSource>();
        music.volume = newVol.value;
        if (music.volume==0) {
            music.mute = true;
        }else {
            music.mute = false;
        }
    }
}

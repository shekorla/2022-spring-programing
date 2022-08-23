using UnityEngine;
using UnityEngine.Events;
public class brick : MonoBehaviour
{
    public UnityEvent deathEv;
    public int maxHits;
    public int currentHits;
    public brickBuilder Boss;
    // Use this for initialization
    void Start () {
	    currentHits = maxHits;
        Boss=Object.FindObjectOfType<brickBuilder>();
    }

    void OnCollisionEnter2D(Collision2D collider) {
        if (collider.gameObject.CompareTag("Player")) { //only counts if you hit player
            currentHits = currentHits - 1;
            if (currentHits <= 0) {
                deathEv.Invoke();
                Boss.brickCount -= 1;
                Destroy(gameObject);
            }
        }
    }
}

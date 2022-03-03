using UnityEngine;
using UnityEngine.Events;
public class brick : MonoBehaviour
{

    public UnityEvent hitEv;
    public int maxHits;
    public int currentHits;
    public brickBuilder Boss;
    public vocalize voca;
    // Use this for initialization
    void Start () {
	    currentHits = maxHits;
        Boss=Object.FindObjectOfType<brickBuilder>();
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Player")) //you got hit
        {
            currentHits = currentHits - 1;
            if (currentHits <= 0)
            {
                hitEv.Invoke();
                Boss.brickCount -= 1;
                voca.hat = true;
                voca.Up();
                Destroy(gameObject);
            }
        }
    }
}

using UnityEngine;
using UnityEngine.Events;

public class ball : MonoBehaviour {

    public paddle paddle;
    public bool haslaunched;
    public Vector2 launchcoord;
    public vocalize voca;
    public UnityEvent startEv;

    private Vector3 paddToBallVector;

	// Use this for initialization
	void Start () {
        haslaunched = false;
        paddToBallVector=this.transform.position - paddle.transform.position;
        startEv.Invoke();
    }
	
	// Update is called once per frame
	void Update () {
        if (haslaunched == false) {
            this.transform.position = paddle.transform.position + paddToBallVector;
            if(Input.GetButtonDown("Fire1")){
                haslaunched = true;
                this.GetComponent<Rigidbody2D>().velocity = launchcoord;
            }
        }
	}

    public void stuck() {
        this.GetComponent<Rigidbody2D>().AddTorque(10);//turn 10 degrees if you get stuck
    }
    void OnCollisionEnter2D(Collision2D collider) {
        voca.polka = true;
        voca.Up();
    }
}

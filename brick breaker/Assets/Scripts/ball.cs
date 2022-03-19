using UnityEngine;
using UnityEngine.Events;

public class ball : MonoBehaviour {

    public paddle paddle;
    public bool haslaunched;
    public Vector2 launchcoord;
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
    public void Dest() {
        Destroy(this);
    }
}

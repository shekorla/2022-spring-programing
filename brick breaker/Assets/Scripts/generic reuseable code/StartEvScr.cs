
using UnityEngine;
using UnityEngine.Events;

public class StartEvScr : MonoBehaviour
{
    public UnityEvent startEv;
    // Start is called before the first frame update
    void Start()
    {
        startEv.Invoke();
    }

    public void forceEvent()
    {
        startEv.Invoke();
    }

}

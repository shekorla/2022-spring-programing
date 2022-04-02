using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignSO : MonoBehaviour
{
    public shopItemSO myData;
    public Text selfText;
    
    // Start is called before the first frame update
    void Start()
    {
        myData.myText = selfText;
    }
}

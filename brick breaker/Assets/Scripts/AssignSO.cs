using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignSO : MonoBehaviour
{
    public shopItemSO myData;
    public Text selfText;
    
    // Start is called before the first frame update
    public void updateData()
    {
        myData.myText = selfText;
        selfText.text = myData.myText.text;
        Debug.Log(myData);
    }
}

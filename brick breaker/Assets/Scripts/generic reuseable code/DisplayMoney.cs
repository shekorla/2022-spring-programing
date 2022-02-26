using System;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMoney : MonoBehaviour
{
    public moneySO sObj;
    public Text myText;
    public bool monScore;//true is money, false is score
    public void Start()
    {
        NewMoney();
    }

    public void NewMoney() {
        if (monScore==true)
        {
            myText.text = "$" + sObj.moneyVal.ToString();
        }
        if (monScore==false)
        {
            myText.text = "SCORE:" + sObj.moneyVal.ToString();
        }
    }
}

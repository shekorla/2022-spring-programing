using System;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMoney : MonoBehaviour
{
    public moneySO sObj;
    public Text myText;
    public bool monScore;//true is money, false is score

    private string introTxt;
     public void Start()
     {
         NewMoney();
     }

    public void NewMoney() {
        if (monScore==true)
        {
            introTxt = "$";
        }
        if (monScore==false)
        {
            introTxt = "SCORE:";
        }
        myText.text = introTxt + sObj.moneyVal.ToString();
    }
}

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ShopItemSC : MonoBehaviour
{
    public UnityEvent EquipEv, buyEvent;
    public int cost = 10;
    public bool locked = true;//must buy if true, can be equiped if false
    public bool equipped = false;
    public Text myText;

    public void Start()
    {
        if (locked==false) {
            if (equipped==true) {
                myText.text = "Equipped";
            }
            else {
                myText.text = "Tap to Equip";
            }
        }
        else {
            myText.text = "$" + cost.ToString();
        }
    }

    public void whenTapped() {
        if (locked==true) {
            buyEvent.Invoke();
        }
        else {
            if (equipped==true) {
                myText.text = "Equipped";
            }
            else {
                EquipEv.Invoke();
            }
        }
    }
    public void canBuy(moneySO moneyS) {
        if(moneyS.moneyVal>=cost)
        {
            locked = false;
            EquipEv.Invoke();
        }
    }
    public void equipMe() {
        equipped = true;
        myText.text = "Equipped";
    }
    public void otherEquip() {
        if (locked==false) {
            equipped = false;
            myText.text = "Tap to Equip";  
        }
    }
}

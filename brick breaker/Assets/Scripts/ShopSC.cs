using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ShopSC : MonoBehaviour
{
    public shopItemSO[] allInShop;
    public moneySO moneyS;
    public Text myText;

    public void Start() {
        foreach (var item in allInShop) {
            if (item.locked == false) {
                if (item.equipped == true) {
                    item.myText.text = "Equipped";
                }
                else {
                    item.myText.text = "Tap to Equip";
                }
            }
            else {
                item.myText.text = "$" + item.cost.ToString();
            }
        }
    }

    public void whenTapped(shopItemSO item) {
        if (item.locked==true) {
            if(moneyS.moneyVal>=item.cost) {
                item.locked = false;
                equip(item);
                moneyS.subMoney(item.cost);
            }
        }
        else {
            equip(item);
        }
    }
    public void equip(shopItemSO item) {
        foreach (var option in allInShop) {
            if (item==option) {
                item.equipped = true;
                item.myText.text = "Equipped"; 
            }
            if (item.locked == false) {
                item.equipped = false;
                item.myText.text = "Tap to Equip";
            }
        }
    }
}

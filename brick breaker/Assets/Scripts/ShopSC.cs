using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ShopSC : MonoBehaviour
{
    public shopItemSO[] BallInShop, PaddleInShop, BrickInShop;
    public UnityEvent equipEv;
    public moneySO moneyS;
    public Text myText;

    private void Start()
    {
        UpdateAllVis(BallInShop);
        UpdateAllVis(PaddleInShop);
        UpdateAllVis(BrickInShop);
    }

    public void UpdateAllVis(shopItemSO[] typeList) {
        foreach (var item in typeList) {
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
                if (item.myType=="ball")
                {
                    equip(item, BallInShop);
                }
                if (item.myType=="brick")
                {
                    equip(item, BrickInShop);
                }
                if (item.myType=="paddle")
                {
                    equip(item, PaddleInShop);
                }
                moneyS.subMoney(item.cost);
            }
        }
        else {
            if (item.myType=="ball")
            {
                equip(item, BallInShop);
            }
            if (item.myType=="brick")
            {
                equip(item, BrickInShop);
            }
            if (item.myType=="paddle")
            {
                equip(item, PaddleInShop);
            }
            
        }
    }
    public void equip(shopItemSO item, shopItemSO[] typeList) {
        foreach (var option in typeList) {
            if (item==option) {
                item.equipped = true;
                item.myText.text = "Equipped"; 
            }
            if (item.locked == false) {
                item.equipped = false;
                item.myText.text = "Tap to Equip";
            }
        }
        equipEv.Invoke();
    }
}

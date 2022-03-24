using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
[CreateAssetMenu]
public class ShopSO : ScriptableObject
{
    public UnityEvent EquipEv, buyEvent;
    public GameObject [] shopInventory;
    public moneySO moneyS;

    public void RoomOpen() {
        foreach (var thisOne in shopInventory) {
            shopItemSO itemData=thisOne.GetComponentInChildren<shopItemSO>();
            Text itemText = thisOne.GetComponentInChildren<Text>();
            if (itemData.locked==false) {
                if (itemData.equipped==true) {
                    itemText.text = "Equipped";
                }
                else {
                    itemText.text = "Tap to Equip";
                }
            }
            else {
                itemText.text = "$" + itemData.cost.ToString();
            }
        }
    }

    public void ItemTapped(GameObject thisOne)
    {
        shopItemSO itemData=thisOne.GetComponentInChildren<shopItemSO>();
        Text itemText = thisOne.GetComponentInChildren<Text>();
        if (itemData.locked==true) {
            buyEvent.Invoke();
            if(moneyS.moneyVal>=itemData.cost)
            {
                itemData.locked = false;
                EquipEv.Invoke();
                equipMe(thisOne,itemData,itemText);
            }
        }
        else {
            if (itemData.equipped==true) {
                itemText.text = "Equipped";
            }
            else {
                EquipEv.Invoke();
                equipMe(thisOne,itemData,itemText);
            }
        }
    }
    public void equipMe(GameObject choosen,shopItemSO itemData,Text itemText) {
        foreach (var Item in shopInventory)
        {
            if (Item==choosen) {
                itemData.equipped = true;
                itemText.text = "Equipped";
            }
            else if (itemData.locked==false) {
                itemData.equipped = false;
                itemText.text = "Tap to Equip";
            }
        }
    }
}

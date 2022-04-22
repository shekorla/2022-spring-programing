using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopUI : MonoBehaviour
{
    public ShopInventorySO shopList;
    
    private float waitTime = 0.1f;
    private shopItemSO newC;
    private List<panelShopCode> buttons;
    private WaitForSeconds wait;

    public void Start()
    {
        BuildShop();
    }

    public void callEquip(shopItemSO choose)
    {
        StopAllCoroutines();
        newC = choose;
        StartCoroutine(ShowEquip());
    }

    private void BuildShop()
    {
        wait = new WaitForSeconds(waitTime);//this sets up wait
        StartCoroutine(ShopLayout());
    }

    private IEnumerator ShopLayout()
    {
        foreach (var item in shopList.shopStock)
        {
            yield return wait;
            var newShopItem = Instantiate(shopList.ShopObj,item.myloc,new Quaternion(0,0,0,0));
            newShopItem.item = item;
            newShopItem.money = shopList.plrMoney;
            ////////////////////buttons.Add(newShopItem);//////////////////this broken
            
        }
    }
    
    private IEnumerator ShowEquip()
    {
        foreach (var button in buttons)
        {
            yield return wait;
            if (button.item==newC)
            {
                button.equip();
            }
            else
            {
                button.remove();
            }
        }
    }

}

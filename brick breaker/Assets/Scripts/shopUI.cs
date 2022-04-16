using System;
using System.Collections;
using UnityEngine;

public class shopUI : MonoBehaviour
{
    public ShopInventorySO shopList;
    public float waitTime = 0.2f;
    
    private WaitForSeconds wait;

    public void Start()
    {
        BuildShop();
    }

    public void BuildShop()
    {
        wait = new WaitForSeconds(waitTime);
        StartCoroutine(ShopLayout());
    }

    private IEnumerator ShopLayout()
    {
        foreach (var item in shopList.shopStock)
        {
            yield return wait;
            var newShop = Instantiate(shopList.ShopObj,item.myloc,new Quaternion(0,0,0,0));
            newShop.item = item;
            newShop.money = shopList.plrMoney;
        }
    }

}

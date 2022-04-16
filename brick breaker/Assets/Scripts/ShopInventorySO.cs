using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ShopInventorySO : ScriptableObject
{
    public moneySO plrMoney;
    public panelShopCode ShopObj;
    public List<shopItemSO> shopStock;
}

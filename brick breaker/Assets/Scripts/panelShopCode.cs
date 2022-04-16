using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class panelShopCode : MonoBehaviour
{
    private Image pic;
    private Text itemLabel;
    private Button buttn;
    [HideInInspector] public shopItemSO item;
    [HideInInspector] public moneySO money;
    private UnityAction buy;
    public UnityAction checkInvent;

    private void Awake()
    {
        pic = GetComponentInChildren<Image>();
        itemLabel = GetComponentInChildren<Text>();
        buttn = GetComponentInChildren<Button>();
        buy+= buyAction;
        //checkInvent.Raise += checkButton;
        buttn.onClick.AddListener(buy);
    }

    private void Start()
    {
        setUpShop();
    }

    private void setUpShop()
    {
        pic.sprite = item.mySprite;
        itemLabel.text = item.cost.ToString();
        checkButton();
    }

    private void checkButton()
    {
        buttn.gameObject.SetActive(true);
        buttn.interactable = money.moneyVal >= item.cost;
        buttn.gameObject.SetActive(!item.locked);
    }

    public void buyAction()
    {
        item.locked = false;
        money.subMoney(item.cost);
        checkInvent.Invoke();
    }
}

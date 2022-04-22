using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class panelShopCode : MonoBehaviour
{
    private SpriteRenderer pic;
    private Text itemLabel;
    private Button buttn;
    [HideInInspector] public shopItemSO item;
    [HideInInspector] public moneySO money;
    private UnityAction buy;
    
    public UnityEvent checkInvent;
    public ArtSO ballart, brickart, paddleart;

    private void Awake()
    {
        pic = GetComponentInChildren<SpriteRenderer>();
        itemLabel = GetComponentInChildren<Text>();
        buttn = GetComponentInChildren<Button>();
        buy+=buyAction;
        //checkInvent.Raise += checkButton;
        buttn.onClick.AddListener(buy);
    }

    private void Start()
    {
        setUpSelf();
    }

    private void setUpSelf()
    {
        pic.sprite = item.mySprite;
        itemLabel.text = "$ "+item.cost.ToString();
        checkButton();
    }

    private void checkButton()
    {
        buttn.gameObject.SetActive(true);
        if (item.locked==true) {
            if ( money.moneyVal >= item.cost) {
                buttn.interactable = true;
            }
            else {
                buttn.interactable = false;
            }
        }
        else
        {
            buttn.interactable = true;
        }
    }

    public void buyAction()
    {
        if (item.locked==true)
        {
            money.subMoney(item.cost);
            item.locked = false;
        }
        switch (item.myType)//ball is 1, brick is 2, paddle is 3
        {
            case 1:
                ballart.currentSprite= item.mySprite;
                break;
            case 2:
                brickart.currentSprite = item.mySprite;
                break;
            case 3:
                paddleart.currentSprite= item.mySprite;
                break;
        }
        checkInvent.Invoke();
    }

    public void equip()
    {
        itemLabel.text = " ";
    }
    public void remove()
    {
        itemLabel.text = "Tap";
    }
    
}

using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu]
public class moneySO: ScriptableObject
{
    public int moneyVal=0;
    public UnityEvent changedEv;

    public void addMoney(int amount)
    {
        moneyVal = moneyVal + amount;
        changedEv.Invoke();
    }
    public void subMoney(int amount)
    {
        if (moneyVal>=amount)
        {
            moneyVal = moneyVal - amount;
            changedEv.Invoke();
        }
    }
    public void levelEnd(moneySO score)
    {
        moneyVal = moneyVal + ((score.moneyVal / 3)*10);
        changedEv.Invoke();
    }

    public void resetVal()
    {
        moneyVal = 0;
        changedEv.Invoke();
    }
}

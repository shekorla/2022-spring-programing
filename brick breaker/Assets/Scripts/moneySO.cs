using UnityEngine;
[CreateAssetMenu]
public class moneySO: ScriptableObject
{
    public int moneyVal=0;

    public void addMoney(int amount)
    {
        moneyVal = moneyVal + amount;
    }
    public void subMoney(int amount)
    {
        if (moneyVal>=amount)
        {
            moneyVal = moneyVal - amount;
        }
    }
    public void levelEnd(moneySO score)
    {
        moneyVal = moneyVal + ((score.moneyVal / 3)*10);
    }

    public void resetVal()
    {
        moneyVal = 0;
    }
}

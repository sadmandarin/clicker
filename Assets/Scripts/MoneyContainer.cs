using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoneyContainer", menuName = "ScriptableObject/MoneyContainer", order = 1)]
public class MoneyContainer : ScriptableObject
{
    [SerializeField]
    private int money;

    public int Money
    {
        get { return money; } 
        set { money = value; }
    }

    public void AddMoney(int amount)
    {
        money += amount;
    }
}

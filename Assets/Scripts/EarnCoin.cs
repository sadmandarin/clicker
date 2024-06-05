using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarnCoin : MonoBehaviour
{
    [SerializeField]
    private MoneyContainer moneyContainer;

    private Button button;

    [SerializeField]
    private LevelContainer levelContainer;

    [SerializeField]
    private CurrentLevelContainer currLvl;

    private void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(EarnMoney);
    }



    private void EarnMoney()
    {
        moneyContainer.AddMoney(CurrAmount());

        Debug.Log(" " + moneyContainer.Money);
    }

    private int CurrAmount()
    {
        for (int i = 0; i < levelContainer.Condition.Count; i++)
        {
            if (currLvl.Level == i)
            {
                return levelContainer.Condition[i].LevelAmount;
            }
        }

        return 0;
    }
}

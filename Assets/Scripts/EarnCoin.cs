using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarnCoin : MonoBehaviour
{
    [SerializeField]
    private MoneyContainer moneyContainer;

    [SerializeField]
    private CurrentEnergy currEnergy;

    private Button button;

    [SerializeField]
    private LevelContainer levelContainer;

    [SerializeField]
    private CurrentLevelContainer currLvl;
    private float elapsedTime = 0;
    private float interval = 1f;

    private void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(EarnMoney);
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        // Если прошло достаточно времени для вызова метода
        if (elapsedTime >= interval)
        {
            // Вызываем ваш метод
            AddEnergy();

            // Сбрасываем прошедшее время
            elapsedTime = 0f;
        }
    }



    private void EarnMoney()
    {
        if (currEnergy.Energy >= levelContainer.Condition[currLvl.Level].LevelAmount)
        {
            moneyContainer.AddMoney(CurrAmount());

            currEnergy.DecreaseEnergy(CurrAmount());

            Debug.Log(" " + moneyContainer.Money);
        }
        
    }
    private void AddEnergy()
    {
        if (currEnergy.Energy < levelContainer.Condition[currLvl.Level].MaxEnergy)
        {
            currEnergy.AddEnergy();
        }
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

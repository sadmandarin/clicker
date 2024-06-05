using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCurrAmout : MonoBehaviour
{
    [SerializeField]
    private CurrentLevelContainer currLvl;

    [SerializeField]
    private LevelContainer levelContainer;

    [SerializeField]
    private MoneyContainer moneyContainer;

    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        text.text = $"{moneyContainer.Money} / {GetMaxMoney()}";
    }

    public int GetMaxMoney()
    {
        for (int i = 0; i < levelContainer.Condition.Count; i++)
        {
            if (currLvl.Level == i)
            {
                return levelContainer.Condition[i].MoneyToUpgrade;
            }
        }

        return 0;
    }
}

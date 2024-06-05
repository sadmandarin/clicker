using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
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

        button.onClick.AddListener(UpLvl);
    }

    void UpLvl()
    {
        for (int i = 0; i < levelContainer.Condition.Count; i++)
        {
            if (i == currLvl.Level)
            {
                if (moneyContainer.Money >= levelContainer.Condition[i].MoneyToUpgrade)
                {
                    currLvl.LevelUp();

                    moneyContainer.Money = moneyContainer.Money - levelContainer.Condition[i].MoneyToUpgrade;
                }
            }
        }
    }
}

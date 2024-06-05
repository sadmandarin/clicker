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

    [SerializeField]
    private CurrentEnergy currEnergy;

    private void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(UpLvl);
    }

    void UpLvl()
    {
        if (moneyContainer.Money >= levelContainer.Condition[currLvl.Level].MoneyToUpgrade)
        {
            moneyContainer.Money = moneyContainer.Money - levelContainer.Condition[currLvl.Level].MoneyToUpgrade;

            currLvl.LevelUp();

            currEnergy.Energy = levelContainer.Condition[currLvl.Level].MaxEnergy;
        }   
    }
}

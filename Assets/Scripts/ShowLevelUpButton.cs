using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLevelUpButton : MonoBehaviour
{
    [SerializeField]
    private MoneyContainer moneyContainer;

    [SerializeField]
    private LevelContainer levelContainer;

    [SerializeField]
    private CurrentLevelContainer currLvl;

    [SerializeField]
    private GameObject button;

    private ShowCurrAmout currAmout;

    private void Start()
    {
        currAmout = GetComponent<ShowCurrAmout>();
    }

    private void Update()
    {
        if (moneyContainer.Money >= currAmout.GetMaxMoney() && currLvl.Level < 4)
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        }
    }
}

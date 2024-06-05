using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField]
    private ShowCurrAmout currAmout;

    [SerializeField]
    private MoneyContainer moneyContainer;

    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();

        float fillCount = (float)moneyContainer.Money / (float)currAmout.GetMaxMoney();

        if (fillCount < 1)
        {
            image.fillAmount = fillCount;
        }

        else
        {
            image.fillAmount = 1;
        }
    }

    private void Update()
    {
        float fillCount = (float)moneyContainer.Money / (float)currAmout.GetMaxMoney();

        if (fillCount < 1)
        {
            image.fillAmount = fillCount;
        }

        else
        {
            image.fillAmount = 1;
        }
    }
}

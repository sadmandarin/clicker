using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowEnergy : MonoBehaviour
{
    [SerializeField]
    private CurrentEnergy currEnergy;

    [SerializeField]
    private LevelContainer lvlContainer;

    [SerializeField]
    private CurrentLevelContainer currLvlContainer;

    private Text energyText;
    void Start()
    {


        energyText = GetComponent<Text>();        
    }

    // Update is called once per frame
    void Update()
    {
        energyText.text = $"{currEnergy.Energy} / {GetMaxEnergy()}";
    }

    int GetMaxEnergy()
    {
        for (int i = 0; i< lvlContainer.Condition.Count; i++)
        {
            if (currLvlContainer.Level == i)
            {
                return lvlContainer.Condition[i].MaxEnergy;
            }
        }

        return 0;
    }
}

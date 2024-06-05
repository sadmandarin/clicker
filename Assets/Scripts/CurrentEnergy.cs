using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CurrentEnergy", menuName = "ScriptableObject/CurrentEnergy", order = 4)]
public class CurrentEnergy : ScriptableObject
{
    [SerializeField]
    private int energy;

    [SerializeField]
    private CurrentLevelContainer currentLvl;

    [SerializeField]
    private LevelContainer levelContainer;

    public int Energy { get { return energy; } set { energy = value; } }

    public void DecreaseEnergy(int amount)
    {
        energy -= amount;
    }

    public void AddEnergy()
    {
        energy += 2;

        if (energy >= levelContainer.Condition[currentLvl.Level].MaxEnergy)
        {
            energy = levelContainer.Condition[currentLvl.Level].MaxEnergy;
        }
    }
}

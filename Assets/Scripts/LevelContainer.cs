using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelContainer", menuName = "ScriptableObject/LevelContainer", order = 2)]
public class LevelContainer : ScriptableObject
{
    [SerializeField]
    private List<LevelCondition> _condition;

    public List<LevelCondition> Condition
    {
        get { return _condition; }
    }
}

[System.Serializable]
public class LevelCondition
{
    [SerializeField]
    private int level;

    [SerializeField]
    private int moneyToUpgrade;

    [SerializeField]
    private int levelAmount;

    public int Level
    {
        get { return level; }
    }

    public int MoneyToUpgrade
    {
        get { return moneyToUpgrade; }
    }

    public int LevelAmount
    {
        get { return levelAmount; }
    }
}

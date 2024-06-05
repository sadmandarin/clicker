using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CurrentLevelContainer", menuName = "ScriptableObject/CurrentLevelContainer", order = 3)]
public class CurrentLevelContainer : ScriptableObject
{
    [SerializeField]
    private int level;

    public int Level { get { return level; } }

    public void LevelUp()
    {
        level++;
    }
}

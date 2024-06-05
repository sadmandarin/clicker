using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrenLvl : MonoBehaviour
{
    [SerializeField]
    private CurrentLevelContainer currLvl;

    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        text.text = $"Уровень {currLvl.Level + 1}";
    }
}

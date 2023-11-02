using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cash : MonoBehaviour
{
    [SerializeField] public int cash = 50;

    [SerializeField] TextMeshProUGUI cashDisplay;

    // Update is called once per frame
    void Update()
    {
        if (cash < 1000)
        {
            cashDisplay.SetText($"${cash}");
        }
        else if (cash >= 1000)
        {
            cashDisplay.SetText($"${cash / 1000}K");
        }
        else if (cash >= 1000000)
        {
            cashDisplay.SetText($"${cash / 1000000}M");
        }
    }
}

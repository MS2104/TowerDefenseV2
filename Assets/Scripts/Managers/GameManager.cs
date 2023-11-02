using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static MainTowerV2 mainTower;
    public static WaveManager waveStat;
    public bool gameActive = true;

    [SerializeField] TextMeshProUGUI healthDisplay;
    [SerializeField] TextMeshProUGUI waveDisplay;

    void Awake() // "erm invalid token void in class" dawg who gives a fuck
    {
        mainTower = FindObjectOfType<MainTowerV2>();
        waveStat = FindObjectOfType<WaveManager>();
    }

    private void Update()
    {
        healthDisplay.SetText($"TOWER HAS {mainTower.health} HP");
        waveDisplay.SetText($"WAVE {waveStat.currentWaveNumber}\nPROGRESS: {waveStat.enemiesSpawned}/{waveStat.currentWaveSize}");

        if (!gameActive)
        {
            Time.timeScale = 0.0f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveDisplay : MonoBehaviour
{
    public WaveManager WaveManager;

    [SerializeField] public TextMeshProUGUI waveDisplayUI;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waveDisplayUI.text = "Wave: " + WaveManager.currentWaveNumber.ToString();
    }
}

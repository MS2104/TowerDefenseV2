using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartWave : MonoBehaviour
{
    public static WaveManager WaveManager;
    private void Awake()
    {
        WaveManager = FindObjectOfType<WaveManager>();
    }

    public void InitiateWave()
    {
        WaveManager.waveActive = true;
        gameObject.SetActive(false);
    }
}

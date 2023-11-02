using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UpgradePrompt : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject upgradePrompt;

    public void OnPointerEnter(PointerEventData eventData)
    {
        upgradePrompt.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        upgradePrompt?.SetActive(false);
    }
}

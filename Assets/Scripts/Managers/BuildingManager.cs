using UnityEngine;
using UnityEngine.UI;

public class BuildingManager : MonoBehaviour
{
    public Button placeTowerButton; // Reference to your PlaceTowerButton

    // Reference to your PlaceTower script (make sure it's assigned in the Unity Editor)
    public PlaceTower placeTowerScript;

    void Start()
    {
        // Make sure the button and script are assigned in the Unity Editor
        if (placeTowerButton != null && placeTowerScript != null)
        {
            placeTowerButton.onClick.AddListener(OnPlaceTowerButtonClick);
        }
        else
        {
            Debug.LogWarning("PlaceTowerButton or PlaceTowerScript is not assigned.");
        }
    }

    void OnPlaceTowerButtonClick()
    {
        placeTowerScript.ToggleBuildingMode();
    }
}
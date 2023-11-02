using UnityEngine;
using UnityEngine.UI;

public class OpenShop : MonoBehaviour
{
    public RectTransform shopPanelRectTransform;
    public Button toggleButton;

    private bool shopIsOpen = false;

    void Start()
    {
        toggleButton.onClick.AddListener(ToggleShopPanel);
    }

    public void ToggleShopPanel()
    {
        shopIsOpen = !shopIsOpen;
        Debug.Log("Button clicked.");

        // Calculate the target position based on whether the shop is open or closed
        Vector2 targetPosition = shopIsOpen ? new Vector2(20f, shopPanelRectTransform.anchoredPosition.y) : new Vector2(-140f, shopPanelRectTransform.anchoredPosition.y);

        // Move the shop panel towards the target position
        shopPanelRectTransform.anchoredPosition = targetPosition;
    }
}
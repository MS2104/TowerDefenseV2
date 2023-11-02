using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class PlaceTower : MonoBehaviour
{
    bool canBuild = false;
    GameObject previewInstance;

    public GameObject towerPreview, towerObj;

    [SerializeField] private Tilemap gridTilemap;
    private Vector3 gridCellSize = new(1f, 1f, 0f);

    private Vector3 mousePosition;

    public Cash cashScript;

    private void Start()
    {
        GameObject gameManagerObject = GameObject.FindWithTag("GameManager");

        cashScript = gameManagerObject.GetComponent<Cash>();
    }
    void Update()
    {
        if (canBuild)
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = 0;

            Vector3Int cellPosition = gridTilemap.WorldToCell(mousePosition);
            Vector3 snappedPosition = gridTilemap.GetCellCenterWorld(cellPosition);

            if (previewInstance == null)
            {
                previewInstance = Instantiate(towerPreview);
            }

            previewInstance.transform.position = snappedPosition;

            if (Input.GetMouseButtonDown(0) && cashScript.cash >= 10)
            {
                canBuild = false;
                Vector3 finalMousePos = gridTilemap.GetCellCenterWorld(cellPosition);
                Instantiate(towerObj, finalMousePos, Quaternion.identity);
                cashScript.cash -= 10;
                Destroy(previewInstance);
            }
            else if (Input.GetMouseButtonDown(0) && cashScript.cash < 10)
            {
                canBuild = false;
                Destroy(previewInstance);

                Debug.Log("Not enough money");
            }
        }
    }

    public void ToggleBuildingMode()
    {
        canBuild = !canBuild;

        if (!canBuild && previewInstance != null)
        {
            Destroy(previewInstance);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class PlaceTower : MonoBehaviour
{
    bool canBuild = false;
    GameObject previewInstance;

    [SerializeField]
    public GameObject towerPreview, towerObj;

    [SerializeField] private Tilemap gridTilemap;
    private Vector3 gridCellSize = new Vector3(1f, 1f, 0f);

    private Vector3 mousePosition;

    /* Wat wij doen hier is wij maken hier een HashSet aan.
    Een HashSet is eigenlijk een list of array maar GEEN ENKEL
    element mag 2x voorkomen. In dit geval maak ik een occupiedPositions
    HashSet aan waarbij ik dus aangeef op welke posities GEEN torens neer mogen
    gezet worden. Zodra ik een toren neerzet op bijvoorbeeld 1, 1, mag er op die
    positie GEEN nieuwe toren neergezet worden.
    */
    private HashSet<Vector3Int> occupiedPositions = new HashSet<Vector3Int>();

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

            if (Input.GetMouseButtonDown(0))
            {
                canBuild = false;
                Vector3 finalMousePos = gridTilemap.GetCellCenterWorld(cellPosition);
                Instantiate(towerObj, finalMousePos, Quaternion.identity);
                Destroy(previewInstance);
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
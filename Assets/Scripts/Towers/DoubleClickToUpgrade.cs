using UnityEngine;

public class DoubleClickToUpgrade : MonoBehaviour
{
    public float clickWindow = 0.3f;

    private float lastClickTime;

    private CircleCollider2D circleCollider;

    private void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(clickPos, Vector2.zero);

            if (hit.collider == null || hit.collider.gameObject != gameObject)
            {
                if (Time.time - lastClickTime < clickWindow)
                {
                    if (CompareTag("Tower"))
                    {
                        Tower tower = GetComponent<Tower>();

                        if (tower != null)
                        {
                            tower.UpgradeTower();
                        }
                    }
                }
                lastClickTime = Time.time;
            }
        }
    }
}

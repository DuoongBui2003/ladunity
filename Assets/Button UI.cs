using UnityEngine;

 using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ButtonUI : MonoBehaviour
{
    public RectTransform menu; // Kéo menu UI vào đây
    public Button toggleButton; // Kéo Button vào đây
    private bool isOpen = false;

    public Vector2 openPosition = new Vector2(0, 0); // Vị trí mở
    public Vector2 closedPosition = new Vector2(0,2000); // Vị trí đóng
    public float moveDuration = 0.5f; // Thời gian di chuyển
    private void Awake()
    {
        toggleButton.onClick.AddListener(ToggleMenu);
    }
    void Start()
    {
       
    }

    public void ToggleMenu()
    {
        isOpen = !isOpen;
        StopAllCoroutines();
        StartCoroutine(MoveMenu(isOpen ? openPosition : closedPosition));
    }

    IEnumerator MoveMenu(Vector2 targetPosition)
    {
        Vector2 startPosition = menu.anchoredPosition;
        float elapsedTime = 0f;

        while (elapsedTime < moveDuration)
        {
            elapsedTime += Time.deltaTime;
            menu.anchoredPosition = Vector2.Lerp(startPosition, targetPosition, elapsedTime / moveDuration);
            Debug.Log("Menu Position: " + menu.anchoredPosition); // In vị trí menu
            yield return null;
        }

        menu.anchoredPosition = targetPosition;
        Debug.Log("Menu Position Final: " + menu.anchoredPosition); // In vị trí cuối cùng
    }

}
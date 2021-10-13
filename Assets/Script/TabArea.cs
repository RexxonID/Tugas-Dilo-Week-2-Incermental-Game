using UnityEngine;
using UnityEngine.EventSystems;

public class TabArea : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown (PointerEventData eventData)
    {
        GameManager.Instance.CollectByTap(eventData.position, transform);
    }
}

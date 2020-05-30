using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Selection : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler

{
    public GameObject arrowImage;

    public void OnPointerEnter(PointerEventData eventData)
    {
        arrowImage.SetActive(true);
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        arrowImage.SetActive(false);
    }
}

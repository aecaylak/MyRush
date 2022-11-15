using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class mobileTouchController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private Image pivotImage;
    private Vector2 _touchPosition;
    public Vector2 _direction { get; private set; } //value can will be readed but cannot be changed
    
    public void OnPointerDown(PointerEventData eventData)
    {
        pivotImage.transform.position = eventData.position;
        pivotImage.gameObject.SetActive(true);
        _touchPosition = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _direction = Vector2.zero;
        pivotImage.gameObject.SetActive(false);
    }

    public void OnDrag(PointerEventData eventData)
    {
        var delta = eventData.position - _touchPosition;
        _direction = delta.normalized; //value's change from screen pixels to -1,1
        Debug.Log(_direction);
    }
}
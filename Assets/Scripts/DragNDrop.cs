using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] Canvas canvas;

    RectTransform myTransform;
    CanvasGroup myCanvasGroup;
    
    void Awake() {
        myTransform = this.GetComponent<RectTransform>();
        myCanvasGroup = this.GetComponent<CanvasGroup>();
    }

    public void OnPointerDown(PointerEventData eventData ) {
        Debug.Log("I am click");
    }

    public void OnBeginDrag( PointerEventData eventData ) {
        Debug.Log("I am begindrag");
        myCanvasGroup.alpha = .5f;
        myCanvasGroup.blocksRaycasts = false;
    }
    public void OnDrag( PointerEventData eventData ) {
        Debug.Log("I am drag");
        myTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    public void OnEndDrag( PointerEventData eventData ) {
        Debug.Log("I am enddrag");
        myCanvasGroup.alpha = 1f;
        myCanvasGroup.blocksRaycasts = true;
    }
    
}

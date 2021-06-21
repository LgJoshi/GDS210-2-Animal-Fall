using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] Canvas canvas;

    Transform myTransform;
    
    
    void Awake() {
        myTransform = this.GetComponent<Transform>();
        
    }

    public void OnPointerDown(PointerEventData eventData ) {
        Debug.Log("I am click");
    }

    public void OnBeginDrag( PointerEventData eventData ) {
        Debug.Log("I am begindrag");
        
        
    }
    public void OnDrag( PointerEventData eventData ) {
        Debug.Log("I am drag");
        
    }
    public void OnEndDrag( PointerEventData eventData ) {
        Debug.Log("I am enddrag");
        
    }
    
}

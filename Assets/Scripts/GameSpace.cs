using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameSpace : MonoBehaviour, IDropHandler {

    RectTransform myTransform;

    private void Awake() {
        myTransform = this.GetComponent<RectTransform>();
    }

    public void OnDrop( PointerEventData eventData ) {
        Debug.Log("I am dropped");
        if( eventData.pointerDrag != null ) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") !=0 ) {
            myTransform.position += new Vector3(0, Input.GetAxis("Mouse ScrollWheel")*5, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{
    // Start is called before the first frame update
bool canMove;
bool dragging;
bool isStartPhase = true;

Collider2D col;

    void Start()
    {
        col = GetComponent<Collider2D>();
        canMove = false;
        dragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isStartPhase){
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(Input.GetMouseButtonDown(0))
            {
                if(col == Physics2D.OverlapPoint(mousePos))
                {
                    canMove = true;
                } else
                {
                    canMove = false;
                }

                if(canMove)
                {
                    dragging = true;
                }
            }
            if(dragging)
            {
                this.transform.position = mousePos;
            }

            if(Input.GetMouseButtonUp(0))
            {
                canMove = false;
                dragging = false;
            }
        }
    }

    void OnEnable() {
        EventManager.PhaseChanged += ChangePhase;
    }
    void OnDisable() {
        EventManager.PhaseChanged -= ChangePhase;
    }

    void ChangePhase(){
        isStartPhase=false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    void OnEnable() {
        EventManager.PhaseChanged += DropAnimal;
    }
    void OnDisable() {
        EventManager.PhaseChanged -= DropAnimal;
    }

    /*
    void OnCollisionEnter2D(Collider2D collide)
    {
        
    }
    */

    void DropAnimal(){
        Debug.Log("DropAnimal function");
        rb.constraints = RigidbodyConstraints2D.None;
        //rb.constraints &= RigidbodyConstraints2D.FreezePositionX;
        //StartCoroutine(DropDelay());
    }

    /*
    IEnumerator DropDelay(){
        yield return new WaitForSeconds(0.2f);
        rb.constraints &= ~RigidbodyConstraints2D.FreezePositionX;
        Debug.Log("x con removed");
    }
    */
}

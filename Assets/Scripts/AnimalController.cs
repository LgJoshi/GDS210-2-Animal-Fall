using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] Vector3 vel;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        anim = this.GetComponent<Animator>();
    }

    void OnEnable() {
        EventManager.PhaseChanged += DropAnimal;
        EventManager.GameEnded += SplatAnimal;
    }
    void OnDisable() {
        EventManager.PhaseChanged -= DropAnimal;
        EventManager.GameEnded -= SplatAnimal;
    }

    void OnTriggerEnter2D(Collider2D collide)
    {
        Debug.Log("collided with "+collide.gameObject.name);
        vel = rb.velocity;
        if (collide.gameObject.name == "Fire"){
            EventManager.GameEndEvent();
        }
        if ((Mathf.Abs(vel.x)+(Mathf.Abs(vel.y))/2 > 5 )) {
            EventManager.GameEndEvent();
        }
        anim.SetBool("IsColliding", true);
    }

    void OnTriggerExit2D(Collider2D collide){
        anim.SetBool("IsColliding", false);
    }

    void DropAnimal(){
        Debug.Log("DropAnimal function");
        rb.constraints = RigidbodyConstraints2D.None;
    }

    void SplatAnimal(){
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        Debug.Log("I go splat!");
    }
}

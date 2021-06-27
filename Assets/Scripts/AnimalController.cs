using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] Vector3 vel;
    Animator anim;
    [SerializeField] GameObject meat;
	[SerializeField] float splatThreshold;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        anim = this.GetComponent<Animator>();
    }

    void OnEnable() {
        EventManager.PhaseChanged += DropAnimal;
        EventManager.GameEnded += FreezeAnimal; 
        EventManager.GameEnded += Splatter;
        EventManager.GameWon += FreezeAnimal;
    }
    void OnDisable() {
        EventManager.PhaseChanged -= DropAnimal;
        EventManager.GameEnded -= FreezeAnimal;
        EventManager.GameEnded -= Splatter;
        EventManager.GameWon -= FreezeAnimal;
    }
    void OnTriggerEnter2D(Collider2D collide)
    {
        Debug.Log("collided with "+collide.gameObject.name);
        vel = rb.velocity;
        if (collide.gameObject.name == "Fire"){
            EventManager.GameEndEvent();
        }

        anim.SetBool("IsColliding", true);
    }
	void OnCollisionEnter2D(Collision2D colis)
	{
		if (colis.relativeVelocity.magnitude > splatThreshold ) {
            EventManager.GameEndEvent();
        } else
		if (colis.gameObject.name == "Goal")
		{
            EventManager.GameWinEvent();
        }
	}
    void OnTriggerExit2D(Collider2D collide){
        anim.SetBool("IsColliding", false);
    }

    void DropAnimal(){
        Debug.Log("DropAnimal function");
        rb.constraints = RigidbodyConstraints2D.None;
    }

    void FreezeAnimal(){
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        Debug.Log("I freeze!");
    }

    void Splatter(){
        Debug.Log("I splat!");
        this.GetComponent<SpriteRenderer>().enabled=false;
        for (int i=0; i<=20;i++){
            var newMeat= Instantiate(meat, this.transform.position, new Quaternion(0,0,Random.Range(0,180),0));
            float randomSpeed = Random.Range(100, 1000);
            float randomDirectionX = Random.Range(-1f, 1f);
            float randomDirectionY = Random.Range(-1f, 1f);
            newMeat.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(randomDirectionX,randomDirectionY)*randomSpeed);
            newMeat.GetComponent<Rigidbody2D>().AddTorque(Random.Range(-500f, 500f));
        }
    }
}

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(LineRenderer))]

public class Shooter : MonoBehaviour {
    public AudioClip throwSound;
    public AudioClip throwSound2;
    public AudioClip throwSound3;
    public Rigidbody bullet;
    public Rigidbody bullet2;
    public Rigidbody bullet3;
    public float throwSpeed = 30.0f;
    private int weapon = 0;
    public static bool canThrow = true;


   
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            weapon++;
            if(weapon == 3)
            {
                weapon = 0;
            }
            var player = GameObject.FindGameObjectWithTag("Player");
            player.SendMessage("changeAttack");
        }

	    if(Input.GetButtonDown("Fire1") && canThrow)
        {
            if(weapon == 0)
            {
                GetComponent<AudioSource>().PlayOneShot(throwSound);
                Rigidbody newBullet = Instantiate(bullet, transform.position + transform.forward, transform.rotation) as Rigidbody;
                newBullet.name = "bullet";
                newBullet.velocity = transform.forward * throwSpeed;
               // Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), newBullet.GetComponent<Collider>(), true);
            } else if(weapon == 1)
            {
                GetComponent<AudioSource>().PlayOneShot(throwSound2);
                Rigidbody newBullet = Instantiate(bullet2, transform.position + transform.forward, transform.rotation) as Rigidbody;
                newBullet.name = "bullet";
                newBullet.velocity = transform.forward * throwSpeed;
                //Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), newBullet.GetComponent<Collider>(), true);
            } else if(weapon == 2)
            {
                GetComponent<AudioSource>().PlayOneShot(throwSound3);
                Rigidbody newBullet = Instantiate(bullet3, transform.position, transform.rotation) as Rigidbody;
                newBullet.name = "bullet3";
               // newBullet.velocity = transform.forward * throwSpeed;
                //Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), newBullet.GetComponent<Collider>(), true);
            }
           
        }
	}

}

using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
    public AudioClip throwSound;
    public Rigidbody bullet;
    public float throwSpeed = 30.0f;
    public static bool canThrow = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("Fire1") && canThrow)
        {
            GetComponent<AudioSource>().PlayOneShot(throwSound);
            Rigidbody newBullet = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            newBullet.name = "bullet";
            newBullet.velocity = transform.forward * throwSpeed;
            Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), newBullet.GetComponent<Collider>(), true);
        }
	}

    
}

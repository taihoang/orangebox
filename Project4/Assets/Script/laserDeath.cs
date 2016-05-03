using UnityEngine;
using System.Collections;

public class laserDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject != GameObject.FindGameObjectWithTag("Player") && col.gameObject != GameObject.FindGameObjectWithTag("terrain"))
        {
            Destroy(col.gameObject);
        }
        Destroy(transform.gameObject);
    }
}

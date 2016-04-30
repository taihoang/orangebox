using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour {
    public float rotationSpeed = 100.0f;
    public AudioClip woohoo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Player")
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(woohoo);
            var controller = col.gameObject;
            controller.SendMessage("setFly", true);
            Destroy(gameObject);
        }
    }

   /* void OnTriggerExit(Collider col)
    {
        if (col.transform.tag == "Player")
        {
            var controller = col.gameObject;
            controller.SendMessage("setFly", false);
        }
    }*/
}

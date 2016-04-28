using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Player")
        {
            var controller = col.gameObject;
            controller.SendMessage("setFly", true);
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

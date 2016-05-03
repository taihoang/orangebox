using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        //    GameObject player
        //print("WTF");
        if (col.gameObject != GameObject.FindGameObjectWithTag("Player"))
        {
            Destroy(col.gameObject);
        }

        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (col.gameObject == GameObject.FindGameObjectWithTag("boss"))
        {

          //  print("what");
            player.SendMessage("DisplayWin");
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GraphicalUI : MonoBehaviour {
    public RawImage attacksGUI;
    public Texture2D[] attacks = new Texture2D[3];
    static int attack = 0;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	  
	}

    void changeAttack()
    {
        //print("WTFFFFF");
        attack++;
        if (attack == 3)
        {
            attack = 0;
        }
        if (attack == 0)
        {
            attacksGUI.texture = attacks[0];
        } else if(attack == 1)
        {
            attacksGUI.texture = attacks[1];
        } else if (attack == 2)
        {
            attacksGUI.texture = attacks[2];
        }
        
        
    }

}

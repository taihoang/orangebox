using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {
    public static int health = 100;
    public RawImage healthGUI;
    public Texture2D[] healthImage = new Texture2D[10];
    public RawImage livesGUI;
    public Texture2D[] livesImage = new Texture2D[3];
    private int lives = 3;

    public RawImage deathScreen;
    public RawImage splashScreen;
    public RawImage winScreen;
    public AudioSource hurtSource;
    public AudioClip hurtSound;
    public AudioClip dieSound;
    public Vector3 spawnPoint;
    public Vector3 rotation;
    // Use this for initialization
    void Start () {
        splashScreen.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            deathScreen.enabled = false;
            splashScreen.enabled = false;
        }
        

    }

    void DisplayWin()
    {
        winScreen.enabled = true;
    }
    void SubtractHealth (int hp)
    {
        
        health -= hp;
        if(health <0)
        {
            hurtSource.PlayOneShot(dieSound);
        } else
        {
            hurtSource.PlayOneShot(hurtSound);
        }
        if(health < 0)
        {
            health = 0;
            lives--;
            health = 100;

            if (lives == 0)
            {
                deathScreen.enabled = true;
                lives = 3;
            }
            transform.position = spawnPoint;
            transform.localEulerAngles = rotation;
        }

        if(lives == 3)
        {
            livesGUI.texture = livesImage[2];
        } else if(lives ==2)
        {
            livesGUI.texture = livesImage[1];
        } else if(lives == 1)
        {
            livesGUI.texture = livesImage[0];
        }

        
        if (health == 100)
        {
            healthGUI.texture = healthImage[10];
        } else if(health <= 100 && health > 90)
        {
            healthGUI.texture = healthImage[9];
        } else if(health <= 90 && health > 80)
        {
            healthGUI.texture = healthImage[8];
        }
        else if (health <= 80 && health > 70)
        {
            healthGUI.texture = healthImage[7];
        }
        else if (health <= 70 && health > 60)
        {
            healthGUI.texture = healthImage[6];
        }
        else if (health <= 60 && health > 50)
        {
            healthGUI.texture = healthImage[5];
        }
        else if (health <= 50 && health > 40)
        {
            healthGUI.texture = healthImage[4];
        }
        else if (health <= 40 && health > 30)
        {
            healthGUI.texture = healthImage[3];
        }
        else if (health <= 30 && health > 20)
        {
            healthGUI.texture = healthImage[2];
        }
        else if (health <= 20 && health > 10)
        {
            healthGUI.texture = healthImage[1];
        }
        else if (health <= 10 && health > 0)
        {
            healthGUI.texture = healthImage[1];
        }


    }
}

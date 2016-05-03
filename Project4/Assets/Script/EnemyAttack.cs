using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

    public float maxDistance = 3;
    public float coolDownTimer = 1;
    public float moveSpeed = 3;
    public float rotationSpeed = 3;
    public GameObject bullet;
    public float throwSpeed = 30;
    public float shootTimer = 3;
    
    private Transform myTransform;
    private Transform target;
    private GameObject player;
    private Animation animate;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;
        myTransform = transform;
        coolDownTimer = 0;
        animate = transform.GetComponent<Animation>();

        
	}
	
	// Update is called once per frame
	void Update () {
        myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);


        float distance = Vector3.Distance(target.position, myTransform.position);
        if(coolDownTimer <= 0 )
        {
           
            coolDownTimer = 0;
        }

        
        if(distance < maxDistance)
        {
            Attack();
        }
        if(coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }
        if(coolDownTimer <= 0)
        {
            coolDownTimer = 0;

        }

        shootTimer -= Time.deltaTime;
      //  print(shootTimer);

        if (distance < 50)
        {
           
            //move towards player
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
        //    animate.Play("move");
            
        }
        if (shootTimer <= 0)
        {
            if (distance < 50)
            {
                shootTimer = 3;
                ShootFireBall();
            }
        }
    }

    void Attack()
    {
        if (coolDownTimer == 0)
        {
            print("WTF");
            player.SendMessage("SubtractHealth", 30);
            coolDownTimer = 1;
        }
    }

    void ShootFireBall()
    {
        
        Rigidbody newBullet = Instantiate(bullet, transform.position + transform.forward * 5 + new Vector3(0, 2, 0), transform.rotation) as Rigidbody;
       // newBullet.name = "fireball";
        Vector3 heading = target.position - (transform.position + transform.forward * 5 + new Vector3(0, 3, 0));
        float distance = heading.magnitude;
        Vector3 shootDirection = heading / distance; //shoot at player
        //shootDirection -= new Vector3(0, 100, 0);
      //  newBullet.velocity = shootDirection * throwSpeed;
       
    }

   
    
}

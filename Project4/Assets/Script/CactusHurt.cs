using UnityEngine;
using System.Collections;

public class CactusHurt : MonoBehaviour
{

    public float maxDistance = 3;
    public float coolDownTimer = 1;
    public float moveSpeed = 3;
    public float rotationSpeed = 3;

    private Transform myTransform;
    private Transform target;
    private GameObject player;
    private Animation animate;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;
        myTransform = transform;
        coolDownTimer = 0;
        animate = transform.GetComponent<Animation>();


    }

    // Update is called once per frame
    void Update()
    {
     

        float distance = Vector3.Distance(target.position, myTransform.position);
        if (coolDownTimer <= 0)
        {

            coolDownTimer = 0;
        }


        if (distance < maxDistance)
        {
            Attack();
        }
        if (coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }
        if (coolDownTimer <= 0)
        {
            coolDownTimer = 0;

        }

        //  print(shootTimer);

     
    }

    void Attack()
    {
        if (coolDownTimer == 0)
        {
            player.SendMessage("SubtractHealth", 30);
            coolDownTimer = 1;
        }
    }
}

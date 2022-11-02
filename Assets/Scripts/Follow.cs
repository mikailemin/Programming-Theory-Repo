using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Follow : Zombies
{
    public GameObject player;

    public NavMeshAgent agent;
    private Animator animator;
   



    void Start()
    {
        animator = GetComponent<Animator>();
        agent.speed = speed;
      
    }

    // Update is called once per frame
    void Update()
    {
      FollowSetup();


    }

   protected override void FollowSetup()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);

       base.FollowSetup();

        if (deger == 0)
        {
            agent.isStopped = false;
            animator.Play("Walking");
            agent.SetDestination(player.transform.position);
        }
        if (deger == 1)
        {
            agent.isStopped = true;
            animator.Play("Punch");
        }
        if (deger == 2)
        {
            agent.isStopped = true;
            animator.Play("Idle");

        }

    }
  
}

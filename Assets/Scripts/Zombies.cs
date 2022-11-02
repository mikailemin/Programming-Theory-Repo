using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Zombies : MonoBehaviour, IHumon<float>
{
    public float MaxHealth { get; set; }
    public float Health { get; set; }

   
    public float speed = 3f;
    public float attackRange = 2;
    public float followRange = 10;
    public float damage = 5;
    protected float deger;
    protected float distance;


    public void GetDamage(float amount)
    {
        Health -= amount;
    }
    protected virtual void FollowSetup()
    {
        if (distance <= followRange && distance > attackRange)
        {
            deger = 0;
        }
        if (distance < attackRange)
        {
            deger = 1;

        }
        if (distance > followRange)
        {
            deger = 2;
        }
    }
   
}

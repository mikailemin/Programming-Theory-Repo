using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Playerss : MonoBehaviour,IHumon<float>
{
    public float MaxHealth { get; set; }
    public float Health { get; set; }

    public void GetDamage(float amount)
    {
        Health -= amount;
    }


    protected virtual void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Damage")
        {
            GetDamage(10);
        }

    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Nesne")
        {
            other.gameObject.SetActive(false);

        }
    }

}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : Playerss
{



    public Slider healthSlider;
    public EnemyScriptibleObject enemy1;
    
   
    void Start()
    {
        Health = 100;
        MaxHealth = 100;


        
      
    }

    // Update is called once per frame
    void Update()
    {

        healthSlider.value = Health;
        healthSlider.maxValue = MaxHealth;

    }
    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
    }

    protected override void OnTriggerEnter(Collider other)
    {
      
       base.OnTriggerEnter(other);
    }
   
   

}

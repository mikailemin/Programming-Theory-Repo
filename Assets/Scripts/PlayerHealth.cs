using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth=100;

    public Slider healthSlider; 

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = health;
    }

    public void GetDamage(float amount)
    {
        health -=amount;
    }


}

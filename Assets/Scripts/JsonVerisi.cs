using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonVerisi
{
    public string Name;
    public float Health;
    public float Damage;

    public JsonVerisi()
    {

    }
    public JsonVerisi(string name, float health,float damage)
    {
        Name = name;
        Health = health;
        Damage=damage;
    }
}

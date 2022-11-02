using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHumon<T> 
{

    public float MaxHealth { get; set; }
    public float Health { get; set; }


   void GetDamage(T amount);


}

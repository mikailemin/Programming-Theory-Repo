using UnityEngine;



[CreateAssetMenu(fileName ="EnemyScriptableObject",menuName ="ScribtableObject/Enemy")]
public class EnemyScriptibleObject : ScriptableObject
{
    public int health = 100;
    public float speed = 3f;
    public float attackRange = 2;
    public float followRange = 10;
    public float damage = 5;
    

}

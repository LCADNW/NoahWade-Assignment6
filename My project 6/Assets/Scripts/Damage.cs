using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] int health;

    public int PlayerHealth
    {
        get { return health; }
        set { health = Mathf.Clamp(value, 0, 100); }
    }

    public int EnemyHealth
    {
        get { return health; }
        set { health = Mathf.Clamp(value, 0, 100);  }
    }

    public int BossHealth
    {
        get { return health; }
        set { health = Mathf.Clamp(value, 0, 300); }
    }

    public void TakeDamage(int damage)
    {
        PlayerHealth -= damage;
        EnemyHealth -= damage;
        BossHealth -= damage;
    }

    public void DealDamage(int damage)
    { 
    
    
    
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
   
    // Start is called before the first frame update
    void Start()
    {
       health = 100;
    }

    private void Update()
    {
        if (health == 0)
        {
            gameObject.SetActive(false);
            Debug.Log("HEHE YOU DIE");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            health -= 50;
        }
       
    }
}

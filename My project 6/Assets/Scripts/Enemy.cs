using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    
    public Transform player;
   


    private void Start()
    {
        health = 50;
        speed = 4;
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, (speed * Time.deltaTime));
    }

    private void Update()
    {
        MoveToPlayer();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
            gameObject.SetActive(false);
        }
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamgeController : MonoBehaviour
{

    public int MaxHealth = 400;
    public int CurrentHealth;

    public DVaHealthBar healthBar;


    void Start()
    {
        CurrentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            AddHealth(20);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        //If the one colliding have the tag Bullet it will be destroyed


        if (other.tag == "Bullet")
        {

            TakeDamage(20);

        }

    }

    void TakeDamage(int damage)
    {
        CurrentHealth -= damage;

        healthBar.SetHealth(CurrentHealth);
    }

    void AddHealth(int AddHelath)
    {
        CurrentHealth += AddHelath;
        healthBar.SetHealth(CurrentHealth);
    }
}

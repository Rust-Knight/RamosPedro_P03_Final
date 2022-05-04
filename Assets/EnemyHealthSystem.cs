using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthSystem : MonoBehaviour
{
    public int EnemyMaxHealth = 400;
    public int CurrentHealth;

    void Start()
    {
        CurrentHealth = EnemyMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        //If the one colliding have the tag Bullet it will be destroyed


        if (other.tag == "DVaBullet")
        {

            EnemyTakeDamage(20);
            Destroy(other.gameObject);

        }

    }

    void EnemyTakeDamage(int damage)
    {
        CurrentHealth -= damage;

        //healthBar.SetHealth(CurrentHealth);
    }



}

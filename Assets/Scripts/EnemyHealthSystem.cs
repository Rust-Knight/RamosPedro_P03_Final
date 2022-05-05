using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthSystem : MonoBehaviour
{
    public int EnemyMaxHealth = 400;
    public int CurrentHealth;

    
    //private AudioSource source;


    void Start()
    {
        CurrentHealth = EnemyMaxHealth;
        //source = GetComponent<AudioSource>();
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
            //source.Play();
        }

    }

    void EnemyTakeDamage(int damage)
    {
        CurrentHealth -= damage;

        //healthBar.SetHealth(CurrentHealth);
    }



}

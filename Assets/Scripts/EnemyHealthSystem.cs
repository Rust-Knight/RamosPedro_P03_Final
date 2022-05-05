using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthSystem : MonoBehaviour
{
    public int EnemyMaxHealth = 400;
    public int CurrentHealth;


    //private AudioSource source;
    [SerializeField]
    private AudioClip _takingDamage;
    private AudioSource _audioSource;

    void Start()
    {
        CurrentHealth = EnemyMaxHealth;

        _audioSource = GetComponent<AudioSource>(); // audio taking damage
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
            _audioSource.Play();
        }

    }

    void EnemyTakeDamage(int damage)
    {
        CurrentHealth -= damage;

        if (_audioSource == null)
        {
            Debug.LogError("Enemy taking damage audio missing!");
        }

        else
        {
            _audioSource.clip = _takingDamage; // damag audio set! 
        }



        //healthBar.SetHealth(CurrentHealth);
    }



}

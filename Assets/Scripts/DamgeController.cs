using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamgeController : MonoBehaviour
{

    public int MaxHealth = 400;
    public int CurrentHealth;

    public DVaHealthBar healthBar;

    [SerializeField] // add audio to shot
    private AudioClip _takeDamage;
    private AudioSource _audioSourcetakeDamage;

    void Start()
    {
        CurrentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
        _audioSourcetakeDamage = GetComponent<AudioSource>(); // hit sound 

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


            _audioSourcetakeDamage.Play(); // hit sound 
        }
        if (other.tag == "BlueBullet")
        {
            TakeDamage(20);

            _audioSourcetakeDamage.Play(); // hit sound 

            Destroy(other.gameObject); // destroy 
        }
    }

    void TakeDamage(int damage)
    {
        CurrentHealth -= damage;

        healthBar.SetHealth(CurrentHealth);

        if (_audioSourcetakeDamage == null) // audio find code
        {
            Debug.LogError("The shot audio for DVa was not found!");
        }
        else
        {
            _audioSourcetakeDamage.clip = _takeDamage;
        } // end audio
    }

    void AddHealth(int AddHelath)
    {
        CurrentHealth += AddHelath;
        healthBar.SetHealth(CurrentHealth);
    }
}

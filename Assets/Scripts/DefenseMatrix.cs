using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseMatrix : MonoBehaviour
{

    public GameObject projectileEaten;
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();// music
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        //If the one colliding have the tag Bullet it will be destroyed

        
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);

            source.Play();
        }

    }
}

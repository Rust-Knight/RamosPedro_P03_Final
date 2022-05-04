using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseMatrix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        //If the one colliding have the tag prey it
        //will get destroyed

        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
        }



        /* private void OnCollisionEnter(Collision collision)
         {
             if (collision.gameObject.CompareTag("Bullet"))
             {
                 Destroy(collision.gameObject);
             }*/
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileA : MonoBehaviour
{

    private bool collided;

    void OnCollisionEnter(Collision co)
    {


        if (co.gameObject.tag != "Bullet" && co.gameObject.tag != "Player" && !collided)
        {

            collided = true;

            Destroy(gameObject);
            //Destroy(gameObject.gameObject, 2); // added 

        }

        else
        {
            Destroy(gameObject, 2); // added 
        }
    }



}

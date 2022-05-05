using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DVaShoot : MonoBehaviour
{

    private Vector3 destination;
    public Camera cam;

    public Transform LCFirePoint, RCFirePoint;
    public float projectileSpeed = 30f;
    public float fireRate = 4;

    public GameObject projectile;
    private bool leftCannon;
    private float timeToFire;


    [SerializeField] // add audio to shot
    private AudioClip _shot;
    private AudioSource _audioSourceDVaShot;





    // Start is called before the first frame update
    void Start()
    {
        _audioSourceDVaShot = GetComponent <AudioSource>(); // Audio Dva shot!
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= timeToFire)
        {

            timeToFire = Time.time + 1 / fireRate;
            ShootProjectile();

            _audioSourceDVaShot.Play();// Audio DVa shotting

            Debug.Log("Pressed Left click.");


        }
    }

    void ShootProjectile()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)); //0.5f, 0.5f, 0 // create ray that the projectile will follow!

        RaycastHit hit;



        if (Physics.Raycast(ray, out hit))
            destination = hit.point;
        else
            destination = ray.GetPoint(1000);

        if (leftCannon)
        {
            leftCannon = false;
            InstantiateProjectile(LCFirePoint);
        }
        else
        {
            leftCannon = true;
            InstantiateProjectile(RCFirePoint);
        }

        if (_audioSourceDVaShot == null) // audio find code
        {
            Debug.LogError("The shot audio for DVa was not found!");
        }
        else
        {
            _audioSourceDVaShot.clip = _shot;
        } // end audio
        
    }

    void InstantiateProjectile(Transform firePoint)
    {
        var projectileObj = Instantiate(projectile, firePoint.position, Quaternion.identity) as GameObject;
        projectileObj.GetComponent<Rigidbody>().velocity = (destination - firePoint.position).normalized * projectileSpeed;
    }
}

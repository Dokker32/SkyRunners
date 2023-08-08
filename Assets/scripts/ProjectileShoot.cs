using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject ProjectilePrefab;
         public float fireRate = 2f;
  private float nextTimeToFire = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {

        if(Input.GetButtonDown("Fire1")&& Time.time >= nextTimeToFire){
    
        nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
       } 
    }
    void Shoot(){
         Instantiate(ProjectilePrefab, transform.position, Quaternion.identity);
    }
}

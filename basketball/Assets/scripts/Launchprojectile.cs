using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launchprojectile : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject Projectile;
    public float launchVelocity = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var _projectile = Instantiate(Projectile, launchPoint.position, launchPoint.rotation);
            _projectile.GetComponent<Rigidbody>().velocity = launchPoint.up * launchVelocity;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float fireInterval = 1.0f;
    public Transform target;

    private void Start()
    {
        InvokeRepeating("Fire", fireInterval, fireInterval);
    }

    private void Fire()
    {
        if (target == null)
            return;

        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        projectile.GetComponent<Projectile>().target = target;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    private bool canShoot = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            StartCoroutine(SpawnBulletWithDelay());
        }
    }

    IEnumerator SpawnBulletWithDelay()
    {
        
        canShoot = false;

        
        SpawnBullet();

      
        yield return new WaitForSeconds(2f);

        
        canShoot = true;
       
    }

    void SpawnBullet()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
        WinLoseCondition.instance.BallsUsed();
    }
}
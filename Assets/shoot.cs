using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bulletPrefab;  // Prefab của đạn
    public Transform bulletSpawnPoint;  // Vị trí khởi tạo đạn
    public float bulletSpeed;  // Tốc độ của đạn
    public float AttackRAnge=5;

    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))  // Bắn khi người chơi nhấn nút bắn (có thể thay đổi theo thiết lập của bạn)
        {
            Shoot();
        }
    }

    void Shoot()
    {

        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);


        Rigidbody bulletController = bullet.GetComponent<Rigidbody>();
        bulletController.AddForce(bulletSpawnPoint.transform.forward * bulletSpeed);
        Destroy(bullet, 3);


    }

}

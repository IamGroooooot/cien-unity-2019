using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootTranform;
    private Vector3 shootPosition;

    // Start is called before the first frame update
    void Start()
    {
        // bullet 생성 1 // 어떻게 생성? (회전도 크기도) bulletPrefab 그대로 //어디에 생성? bullet의 position 사용 
        Instantiate(bulletPrefab);

        // bullet 생성 2 // 어떻게 생성? bulletPrefab의 rotation //어디에 생성? 게임오브젝트 ShootPosition의 위치
        shootPosition = new Vector3(shootTranform.position.x, shootTranform.position.y, shootTranform.position.z);
        Instantiate(bulletPrefab, shootPosition, bulletPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
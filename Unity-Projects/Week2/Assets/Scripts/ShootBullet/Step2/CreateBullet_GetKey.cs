using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullet_GetKey : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform shootTranform;
    private Vector3 shootPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            shootPosition = new Vector3(shootTranform.position.x, shootTranform.position.y, shootTranform.position.z);
            Instantiate(bulletPrefab, shootPosition, bulletPrefab.transform.rotation);
        }
    }
}

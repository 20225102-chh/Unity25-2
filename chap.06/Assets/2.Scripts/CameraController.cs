using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;

    //public GameObject player;
    //void Start()
    //{
    //    //player = GameObject.Find("cat_0");
    //}

    void Update()
    {
        Vector3 playerPos = playerTransform.position;
        transform.position = new Vector3(transform.position.x, 
                                         playerTransform.position.y+3, 
                                         transform.position.z);
    }
}

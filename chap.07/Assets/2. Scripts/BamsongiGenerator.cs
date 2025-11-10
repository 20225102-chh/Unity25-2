using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject BamsongiPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject go = Instantiate(BamsongiPrefab);
            go.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
            go.GetComponent<BamsongiController>().Shoot(new Vector3(0, 500, 2000));
        }
    }
}

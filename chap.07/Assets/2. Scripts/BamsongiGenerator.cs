using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject BamsongiPrefab;
    public float throwForce = 5f;
    float startValue;
    float power;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startValue = Input.mousePosition.y;
        }

        if (Input.GetMouseButtonUp(0))
        {
            power = Input.mousePosition.y - startValue;

            GameObject go = Instantiate(BamsongiPrefab);
            go.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
            go.GetComponent<BamsongiController>().Shoot((transform.forward + transform.up * 0.5f) * throwForce * power);
        }
    }
}

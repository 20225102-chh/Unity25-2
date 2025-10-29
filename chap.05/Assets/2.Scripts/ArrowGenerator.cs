using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            float px = Random.Range(-8.0f, 8.0f);
            go.transform.position = new Vector3(px, 6, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 1.0f;
    float startSpeed = 15f;
    float dRatio = 0.995f;
    float minSpeed = 0.2f;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            this.rotSpeed = this.startSpeed;
        }

        transform.Rotate(0, 0, -this.rotSpeed);
        this.rotSpeed *= this.dRatio;

        if ( this.rotSpeed < minSpeed )
        {
            this.rotSpeed = 0f;
        }
    }
}

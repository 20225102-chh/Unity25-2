using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    public int forwardForce = 2000;
    public int upforce = 500;

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce (dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
        GetComponentInChildren<MeshRenderer>().enabled = false;
        Destroy(gameObject, 1);
    }
    void Start()
    {
        Application.targetFrameRate = 60;
        //Shoot(new Vector3(0, upforce, forwardForce));
        Destroy(gameObject, 5);
    }

}

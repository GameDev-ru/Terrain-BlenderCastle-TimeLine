using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLine : MonoBehaviour
{
    private float force = 1000f;


    public void AddForce()
    {
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(transform.up * force);
        rb.AddForce(new Vector3(-1, 0, 1) * force/2);
    }

    public void Up()
    {
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(transform.up * force);
    }

    public void DestroyObj()
    {
        Destroy(this.gameObject);
    }
}

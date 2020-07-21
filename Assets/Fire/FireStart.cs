using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStart : MonoBehaviour
{

    private ParticleSystem fire;

    void Start()
    {
        fire = GetComponent<ParticleSystem>();
    }

    public void StartFire()
    {
        fire.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

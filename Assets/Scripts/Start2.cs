using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Start2 : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    private PlayableDirector timeLine2;

    void Start()
    {
        timeLine2 = GetComponent<PlayableDirector>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            timeLine2.Play();
        }
    }
}

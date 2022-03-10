using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whistleScript : MonoBehaviour
{
    public ParticleSystem system;
    public AudioSource rapport;
    public AudioSource whistle;
    public string key;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key)) {
          system.Play();
          rapport.Play();
          whistle.Play();
        }
    }
}

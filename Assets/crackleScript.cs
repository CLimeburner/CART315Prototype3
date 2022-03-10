using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crackleScript : MonoBehaviour
{
    public ParticleSystem system;
    public AudioSource rapport;
    public AudioSource crackle;
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
          Invoke("Crackle",0.5f);
        }
    }

    void Crackle()
    {
      crackle.Play();
    }
}

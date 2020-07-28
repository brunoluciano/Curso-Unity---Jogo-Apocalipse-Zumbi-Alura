using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaArma : MonoBehaviour
{
    public GameObject Bala;
    public GameObject CanoDaArma;
    public AudioClip SomDeTiro;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ControlaAudio.instancia.PlayOneShot(SomDeTiro);
            Instantiate(Bala, CanoDaArma.transform.position, CanoDaArma.transform.rotation);
        }
    }
}

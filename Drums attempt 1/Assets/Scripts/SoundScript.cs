using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioSource au;
    public AudioSource au2;


    void Start(){
        au = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other){
        au.Play();
        if(other.gameObject.tag == "stick"){
            au2.Play();
        }
    }
}

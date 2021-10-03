using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private AudioSource sound;
    void Start(){
        sound = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other){
        sound.Play();
        Destroy(gameObject, 0.1f);

    }
}

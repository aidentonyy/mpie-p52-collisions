using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    public AudioClip DoorOpenAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        GameObject parent = transform.parent.gameObject;       
        Animation animation = parent.GetComponent<Animation>();       
        animation.Play("OpenDoor");
          
          AudioSource DoorOpenClip = GetComponent<AudioSource>();
            DoorOpenClip.clip = DoorOpenAudio;
            DoorOpenClip.Play(); 
          
        }

        // void OnTriggerExit(Collider other){
        // GameObject parent = transform.parent.gameObject;       
        // Animation animation = parent.GetComponent<Animation>();       
        // animation.Play("Close");
        // }

}

    
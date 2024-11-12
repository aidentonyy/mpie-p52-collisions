using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun : MonoBehaviour
{

    public AudioClip emptyGunClip;
    public AudioClip shootClip;
    public AudioClip RadioClip;
    public AudioClip DoorClip;
    public AudioClip AmmoPickup;  
    public AudioClip Wind;  
    public AudioClip BridgeDraw;  



    public int Ammo = 0;

        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){

            if(Ammo==0){
                AudioSource emptyGun = GetComponent<AudioSource>();
                emptyGun.clip = emptyGunClip;
                emptyGun.Play();          
              }
            if(Ammo!=0){
            Shoot();
            AudioSource shootClipAudio = GetComponent<AudioSource>();
                shootClipAudio.clip = shootClip;
                shootClipAudio.Play();  
            }
        }
    }

     void OnTriggerEnter(Collider AmmoBox){
        AmmoBox.gameObject.SetActive(false);
        Ammo += 20;

        
        AudioSource AmmoPickupAudio = GetComponent<AudioSource>();
                AmmoPickupAudio.clip = AmmoPickup;
                AmmoPickupAudio.Play(); 
        }

        void Shoot(){
        Ray ray =  Camera.main.ViewportPointToRay(new Vector3(0.5f ,0.5f ,0.0f));
        RaycastHit result; 
        Physics.Raycast(ray, out result);

        GameObject g = result.collider.gameObject;
        Animation a = g.transform.parent.GetComponent<Animation>();
        a.Play("LowerBridge");
    }                   



}

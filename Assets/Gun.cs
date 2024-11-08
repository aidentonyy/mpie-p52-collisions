using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int Ammo = 0;

        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider AmmoBox){
        AmmoBox.gameObject.SetActive(false);
        Ammo += 20;
        }

        void Shoot(){
            
        }

}

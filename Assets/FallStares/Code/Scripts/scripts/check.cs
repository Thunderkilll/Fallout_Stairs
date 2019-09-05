using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{  
 
    
    
    
  
    private void OnTriggerEnter(Collider other)
    {
        if ((gameObject.tag == "ckeck1")&&(other.tag=="Player")) {
           
            SpawnStairs.instance.doo();
            
        
            
        }
      

       

    }

}
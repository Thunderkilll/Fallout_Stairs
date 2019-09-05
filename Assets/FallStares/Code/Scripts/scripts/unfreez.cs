using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unfreez : MonoBehaviour
{


   private void Update()
    {
        if (RotateAround.instance.move == true)
            unfreeze();
    }


    void unfreeze()
    {
       
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
}

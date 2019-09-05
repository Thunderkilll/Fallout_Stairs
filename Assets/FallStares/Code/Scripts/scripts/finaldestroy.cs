using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finaldestroy : MonoBehaviour {
    public GameObject final;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(final);
        }
    }
}

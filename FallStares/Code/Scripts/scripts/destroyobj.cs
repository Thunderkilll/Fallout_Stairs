using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyobj : MonoBehaviour {
    float j = 0;
    bool tah = false;
    public Transform obj;
    // Use this for initialization
    void Start () {
        j = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if ((j < 6) && (tah == true))
            j += 1 * Time.deltaTime;
      
        if (j >= 5)
            Destroy(obj.gameObject);
    }
    private void OnTriggerExit(Collider other)
    {

        tah = true;
        obj = gameObject.transform.parent;
       


    }
}

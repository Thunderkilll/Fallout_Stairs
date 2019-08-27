using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStairs : MonoBehaviour
{
    public GameObject stairr;


    public static float k;
    public static float f;
    public static SpawnStairs instance;
    // Use this for initialization
    private void Start()
    {
        k = stairr.transform.position.x;
        f = stairr.transform.position.y;
        instance = this;
    }

    public void doo()
    {
            k -= 0.52f;
            f -= 26.65f;
            Instantiate(stairr, new Vector3(k, f, stairr.transform.position.z), stairr.transform.rotation);
           
        }
   



}
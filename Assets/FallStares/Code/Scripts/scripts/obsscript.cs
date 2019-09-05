using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsscript : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;


    int i = 0;
    // Use this for initialization
    void Start()
    {
        i = Random.Range(0, 4);

        if (i == 1)
        {
            cube1.SetActive(true);
        }
        if (i == 2)
        {
            cube2.SetActive(true);
        }
        if (i == 3)
        {
            cube3.SetActive(true);
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerexit : MonoBehaviour {
    public GameObject Gameover;
    public GameObject Player;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") Gameover.SetActive(true);
    }
    private void Update()
    {
        transform.position=new Vector3 (transform.position.x, Player.transform.position.y, transform.position.z);
    }
}

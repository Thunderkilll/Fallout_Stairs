using System.Collections;

using UnityEngine;

public class RotateAround : MonoBehaviour {

    public static RotateAround instance;

    public float speedRotation = 10f;
    public GameObject pole;
    
  

    public bool move = false;
    

    public float speed=1;
  
    
    private void Start()
    {
        instance = this;
        
    }

  
    void Update () {
        
        OrbitAround();
      
      
        
    }

   
    public void OrbitAround()
    {
        if (move == true)
        {
           if(ObstacleCollision.instanceObstacleCollision.staystill==false)
                transform.RotateAround(pole.transform.position, Vector3.down, speedRotation * Time.deltaTime);
            //else
            //    transform.RotateAround(pole.transform.position, Vector3.down, speedRotation/5* Time.deltaTime);

        }
    }
 
    public void unAnimator()
    {
        GetComponent<Animator>().enabled = false;
        move = true;

    }

   
}

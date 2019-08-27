using UnityEngine;

public class movescript : MonoBehaviour
{
    public Transform Hips;
    
    float distance=20;
    public float g= 0.8f;
    
    public static float i = 0;
    public Joystick joystick;

    private void OnMouseDrag()
    {

        if (RotateAround.instance.move == true)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            if (Input.GetMouseButton(0))
            {
                if ((i < 1))
                {
                    i += 1 * Time.deltaTime;


                    Hips.GetComponent<Rigidbody>().AddForce((objPosition - transform.position) * g, ForceMode.VelocityChange);
                    Hips.GetComponent<Rigidbody>().velocity = Vector3.zero;


                }


            }
        }
       
    }
    private void Update()
    {
        
        if (Input.GetMouseButtonUp(0)) {  i = 0; }
    }
}
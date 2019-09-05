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
            Vector3 JoystickPosition = new Vector3(joystick.Horizontal, joystick.Vertical, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector3 objPosition2 = Camera.main.ScreenToWorldPoint(JoystickPosition);
            if (joystick.Horizontal >= .2f || joystick.Horizontal <= -.2f)
            {
                gameObject.GetComponent<Rigidbody>().AddForce((objPosition2 - transform.position) * g, ForceMode.VelocityChange);
                if ((i < 1))
                {
                    i += 1 * Time.deltaTime;


                    Hips.GetComponent<Rigidbody>().AddForce((objPosition2 - transform.position) * g, ForceMode.VelocityChange);
                    Hips.GetComponent<Rigidbody>().velocity = Vector3.zero;


                }


            }
            if (joystick.Vertical >= .2f || joystick.Vertical <= -.2f)
            {
                i += 1 * Time.deltaTime;
                Hips.GetComponent<Rigidbody>().AddForce((objPosition2 - transform.position) * g, ForceMode.VelocityChange);
                Hips.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
       
    }
    private void Update()
    {
        
        if (joystick.Horizontal >= .2f || joystick.Vertical >= .2f) {  i = 0; }
    }
}
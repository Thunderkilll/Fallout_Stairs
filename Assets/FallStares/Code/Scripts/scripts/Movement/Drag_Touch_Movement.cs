using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KhaledGuesmi
{

    public class Drag_Touch_Movement : MonoBehaviour
    {
        public Transform Hips;

        float distance = 20;
        public float g = 0.8f;

        public static float i = 0;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }


        public void DragFingers()
        {
            #region code drag

        
            if (RotateAround.instance.move == true)
            {
                //if touch event take place 
                //init touch event 
                if (Input.touchCount > 0)
                {
                    //get touch to take a deal with 
                    Touch touch = Input.GetTouch(0);
                    //obtain position for 3d dimension
                    Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
                    switch (touch.phase)
                    {
                        case TouchPhase.Began:
                            if ((i < 1))
                            {
                                i += 1 * Time.deltaTime;


                                Hips.GetComponent<Rigidbody>().AddForce((touchPos - transform.position) * g, ForceMode.VelocityChange);
                                Hips.GetComponent<Rigidbody>().velocity = Vector3.zero;


                            }
                            break;
                        case TouchPhase.Moved:
                            break;
                        case TouchPhase.Stationary:
                            i--;
                            break;
                        case TouchPhase.Ended:
                            break;
                        case TouchPhase.Canceled:
                            break;
                        default:
                            break;
                    }
                }

            }
            #endregion

        }
    }
}
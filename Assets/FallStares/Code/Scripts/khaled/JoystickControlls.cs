using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KhaledGuesmi
{
    public class JoystickControlls : MonoBehaviour
    {
        public Joystick joystick;
        public float runSpeed = 10f;
        public float speed = 1f;
        float horizontalMove = 0f;
        GameObject STAIRS;
        public Transform player;
        GameObject pole;
        void Start()
        {
            STAIRS = GameObject.FindGameObjectWithTag("Stairs");
            pole = GameObject.Find("Pole");

        }
        void Update()
        {
            RelativePos();


            //if (joystick.Vertical >= .2f)
            //{

            //    horizontalMove = runSpeed;

            //    gameObject.transform.Translate(horizontalMove * Vector3.forward * Time.deltaTime);

            //    Debug.Log(gameObject.transform.position.z);
            //}
            //if (joystick.Vertical <= -.2f)
            //{

            //    horizontalMove = runSpeed;

            //    gameObject.transform.Translate(horizontalMove * Vector3.back * Time.deltaTime);
            //    Debug.Log(gameObject.transform.position.z);
            //}
        }

        public void RelativePos()
        {
            Vector3 relativePoint = player.InverseTransformPoint(STAIRS.transform.position.x, STAIRS.transform.position.y, STAIRS.transform.position.z);
           // Debug.Log(relativePoint);
            horizontalMove = joystick.Horizontal * runSpeed;
            if (relativePoint.x > 0)
            {
                if (joystick.Horizontal >= .2f)
                {

                    horizontalMove = runSpeed;

                    gameObject.transform.Translate(horizontalMove * Vector3.right * Time.deltaTime);
                    float step = speed * Time.deltaTime; // calculate distance to move
                    transform.position = Vector3.MoveTowards(player.position, pole.transform.position, step);

                }
                if (joystick.Horizontal <= -.2f)
                {
                    horizontalMove = runSpeed;

                    gameObject.transform.Translate(horizontalMove * Vector3.left * Time.deltaTime);

                }
            }
            else if (relativePoint.x < 0)
            {
                if (joystick.Horizontal >= .2f)
                {

                    horizontalMove = runSpeed;

                    gameObject.transform.Translate(horizontalMove * Vector3.left * Time.deltaTime);

                }
                if (joystick.Horizontal <= -.2f)
                {
                    horizontalMove = runSpeed;
                    gameObject.transform.Translate(horizontalMove * Vector3.right * Time.deltaTime);


                }
            }
        }

    }
}


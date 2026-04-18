using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
        public float moveSpeed = 10f;     

        void Update()
        {
           
            float horizontal = 0f;
            float vertical = 0f;

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                horizontal = 1f;

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                horizontal = -1f;

            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
                vertical = 1f;

            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
                vertical = -1f;

            Vector3 movement = new Vector3(horizontal, 0f, vertical);

            transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
        }
    }

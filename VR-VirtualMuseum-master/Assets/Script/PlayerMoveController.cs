using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMoveController : MonoBehaviour
{
    CharacterController playerController;

    Vector3 direction;
    public bool gameover=false;
    public float speed = 1;
    public float jumpPower = 5;
    public float gravity = 7f;
    public bool UIstate=false;

    public float mousespeed = 5f;


    public float minmouseY = -45f;
    public float maxmouseY = 45f;

    float RotationY = 0f;
    float RotationX = 0f;

    public Transform agretctCamera;


    // Use this for initialization
    void Start()
    {
        playerController = this.GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (UIstate == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            float _horizontal = Input.GetAxis("Horizontal");
            float _vertical = Input.GetAxis("Vertical");

            if (playerController.isGrounded)
            {
                direction = new Vector3(_horizontal, 0, _vertical);
                if (Input.GetKeyDown(KeyCode.Space))
                    direction.y = jumpPower;
            }
            direction.y -= gravity * Time.deltaTime;
            playerController.Move(playerController.transform.TransformDirection(direction * Time.deltaTime * speed));

            RotationX += agretctCamera.transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mousespeed;

            RotationY -= Input.GetAxis("Mouse Y") * mousespeed;
            RotationY = Mathf.Clamp(RotationY, minmouseY, maxmouseY);

            this.transform.eulerAngles = new Vector3(0, RotationX, 0);

            agretctCamera.transform.eulerAngles = new Vector3(RotationY, RotationX, 0);
        }
           
        
       
      
        

    }
}

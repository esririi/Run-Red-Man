using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerManager : MonoBehaviour
{
    private Rigidbody2D rgbPlayer;
    private InputSystem inputSystem;
    private InputAction jumpAction;
    [SerializeField] private int powerToJump;
    public GameObject soilParticle;
   




    private void Awake()
    {
        InGameSceneMenuManager Instance = new InGameSceneMenuManager();
        inputSystem = new InputSystem();
        jumpAction = inputSystem.Player.Jump;

    }

    

    private void OnEnable()
    {
        Debug.Log("Enable çalýþtý.");
        jumpAction.Enable();
        jumpAction.performed += Jump;

    }



    private void OnDisable()
    {
        Debug.Log("Disable çalýþtý.");
        jumpAction.Disable();
    }

    private void Start()
    {
        rgbPlayer = this.GetComponent<Rigidbody2D>();
    }


    private void Jump(InputAction.CallbackContext context)
    {
        if (PlayerCheckerManager.instance.canJump == true)
        {
            rgbPlayer.AddForce(new Vector2(0, 1) * powerToJump, ForceMode2D.Impulse);
            PlayerCheckerManager.instance.canJump = false;
            soilParticle.SetActive(false);
            PlayerCheckerManager.instance.playerAnimator.SetBool("IsGroundedAnim", false);
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0;
            InGameSceneMenuManager.Instance.Dead();
        }
    }



}



















































//public Rigidbody2D rgbPlayer;
//[SerializeField] private int powerToJump;





//void Start()
//{

//}


//void Update()
//{
//    if (Input.GetKeyDown(KeyCode.Space))
//    {
//        Vector2 jumpVector = new Vector2(0, 1);
//        rgbPlayer.AddForce(jumpVector * powerToJump);
//    }
//}
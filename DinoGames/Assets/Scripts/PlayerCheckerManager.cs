using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckerManager : MonoBehaviour
{
    public Animator playerAnimator;
    public static PlayerCheckerManager instance;
    public bool canJump = false;
    public GameObject soilParticle;
    

    private void Awake()
    {
        instance = this;   
    }
    private void Start()
    {
        playerAnimator = GetComponentInParent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Ground")
        {
            canJump = true;

            playerAnimator.SetBool("IsGroundedAnim", true);
            soilParticle.SetActive(true);
        }
    }
    

}

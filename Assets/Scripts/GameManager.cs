using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Animator playerAnimator;


    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
        playerAnimator.SetTrigger("Jump");
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
        playerAnimator.SetTrigger("Left");
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
        playerAnimator.SetTrigger("Right");
        }
    }
}

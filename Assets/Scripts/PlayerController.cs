using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnim;
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) 
        {
            playerAnim.SetFloat("Speed", 10);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            playerAnim.SetFloat("Speed", 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    Animator a;
    float directionX, directionZ;

    CharacterController controller;
    Vector3 moveDirection = Vector3.zero;
    void Start()
    {
        a = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        directionX = Input.GetAxis("Horizontal");
        directionZ = Input.GetAxis("Vertical");
        moveDirection = new Vector3(directionX, 0, directionZ);
        a.SetFloat("Horizontal", directionX);
        a.SetFloat("Vertical", directionZ);
    }

    void FixedUpdate()
    {
        Vector3 move = moveDirection * 1f * Time.deltaTime;
        controller.Move(move);
    }
}

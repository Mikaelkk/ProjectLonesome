﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public Interactable focus;

    public LayerMask movementMask;

    Camera cam;
    PlayerMotor motor;

    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))    // Check for left-click mouse button
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {
                motor.MoveToPoint(hit.point);   // Move to where we hit

                RemoveFocus();

            }
        }

        if (Input.GetMouseButtonDown(1))    // Check for right-click mouse button
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if(interactable != null)
                {
                    SetFocus(interactable);
                }

            }
        }
    }

    void SetFocus (Interactable newFocus)
    {
        focus = newFocus;
        motor.FollowTarget(newFocus);
    }

    void RemoveFocus()
    {
        focus = null;
        motor.StopFollowingTarget();
    }
}

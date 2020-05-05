using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
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
                //Debug.Log("Hit " + hit.collider.name + " " + hit.point);
                motor.MoveToPoint(hit.point);

                // Stop focusing any objects

            }
        }

        if (Input.GetMouseButtonDown(1))    // Check for right-click mouse button
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                // Check if we hit an interactable
                // Set focus

            }
        }
    }
}

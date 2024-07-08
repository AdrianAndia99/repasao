using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    [SerializeField] Vector2 axisMovement;
    Rigidbody rb;
    [SerializeField] float speed;
    bool interaccion;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnDaño()
    {
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(axisMovement.x* speed, rb.velocity.y, axisMovement.y* speed);
    }
    public void OnMovement(InputAction.CallbackContext value)
    {
        axisMovement = value.ReadValue<Vector2>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC")) 
        {
            GameController.Interacction?.Invoke(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            GameController.Interacction?.Invoke(false);
        }
    }
}

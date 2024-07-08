using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class HealthController : MonoBehaviour
{
    [SerializeField] UnityAction<int> healthController;
    int currentLife =100;
    private void Awake()
    {
        healthController += onListenerHealth;
    }
    public void onListenerHealth(int value)
    {
        currentLife += value;
        if (currentLife <= 0)
        {
             GameController.OnLose?.Invoke();
        }
        healthController?.Invoke(currentLife);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            onListenerHealth(-5);
        }
    }
}

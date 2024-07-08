using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    [SerializeField] UnityEvent<int> scoreController;
    public void onListenerScore()
    {
        
    }
}

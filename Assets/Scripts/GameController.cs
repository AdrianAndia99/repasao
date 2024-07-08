using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class GameController : MonoBehaviour
{
    static public Action<bool> Interacction;

    //Eventos de Ganar y perder
    public static Action OnLose;
    public static Action OnWin;
    
    bool interaction = false;
    private void Awake()
    {
        
    }

    private void OnEnable()
    {
        Interacction += OnInteraction;
        OnLose += OnLoseMetodo;
    }
    void OnInteraction(bool waza)
    {
        interaction = waza; 
    }
    public void OnInteracteble1(InputAction.CallbackContext value)
    {
        if (value.started && interaction)
        {
            print("Hola");
        }
    }
    
    public void SoundUpdateLife()
    {
        print("Soudn");  
    }
    public void OnLoseMetodo()
    {
        print("Perdiste");
    }
}

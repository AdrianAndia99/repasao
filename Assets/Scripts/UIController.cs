using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] TMP_Text textLife;

    public void UPdateLife(int value)
    {
        textLife.text = value.ToString();
    }
}

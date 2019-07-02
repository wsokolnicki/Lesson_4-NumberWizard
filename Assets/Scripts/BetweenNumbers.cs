using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BetweenNumbers : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] Text BetweenNum;
 
    void Start()
    {
        BetweenNum.text = min.ToString() + " and " + max.ToString();
    }
}	

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusVisual : MonoBehaviour
{
    [SerializeField] private Text output;
    [SerializeField] private Bonus bonus;
    

    private void Update()
    {
        output.text =$"{bonus.Value}" ;
    }
 
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Globalization;
using System.Globalization;
using System.Data;

public class TimeBonus : MonoBehaviour
{
    [SerializeField] private Bonus bonus;
    [SerializeField] private int sizeGetTime = 10;


    public UnityEvent activateTimeEvent;
    public UnityEvent updateActivateTimeEvent;
 

 
    public void Activate()
    {
        activateTimeEvent?.Invoke();
  
    }
 
    private void Update()
    {
        int allMinutes = DateTime.Now.Hour * 60 + DateTime.Now.Minute;
        if (Mathf.Abs(bonus.LastGetTime - allMinutes ) >= sizeGetTime)
        {
            bonus.SetLastTime(allMinutes);
            updateActivateTimeEvent?.Invoke();
        }
    }
}
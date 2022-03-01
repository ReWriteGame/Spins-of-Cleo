using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    public UnityEvent getBulletEvent;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.GetComponent<Bullet>())
            getBulletEvent?.Invoke();
   
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D col)
  {
   if(col.gameObject.GetComponent<Destroyer>())
       gameObject.GetComponent<Destroyable>().Destroy();
   
   if(col.gameObject.GetComponent<Ball>())
       gameObject.GetComponent<Destroyable>().Destroy();
  }
}

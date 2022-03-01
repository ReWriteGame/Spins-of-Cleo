using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBonusBullet : MonoBehaviour
{
   [SerializeField] private Bonus bonus;
   [SerializeField] private ScoreCounter score;

   public void AddWinScore()
   {
      bonus.AddScore((int)score.Score);
   }
}

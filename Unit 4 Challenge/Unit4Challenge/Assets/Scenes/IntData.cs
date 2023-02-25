using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Player Info", menuName = "Player Info")]
public class IntData : ScriptableObject
{
   public new string name;
   public string description;
   public int attackLevel;
   public int powerLevel;
   public int healthLevel;

   public void Print()
   {
      Debug.Log(name + ": " + description + " and his power level is " + powerLevel);
   }

}
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "CD_Level" , menuName = "Picker3D/CD_Level", order =1)]
//menü name picker3d is cd level olu?tur something like that 

public class CD_Level : ScriptableObject
{
   public List<LevelData> Levels = new List<LevelData>();
}

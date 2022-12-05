using System;
using Unity.Mathematics;


namespace Data.ValueObjects
{

     [Serializable]
     public class InputData
     {
          public float HorizontalInputSpeed; // = 1.2f;
          public float2 ClampValues; // = new float2(x:-3, y:3);
          public float ClampSpeed; // = 0.07f;

          public InputData(float horizontalInputSpeed, float2 clampValues, float clampSpeed)
          {
               HorizontalInputSpeed = 1.2f;
               ClampValues = clampValues;
               ClampSpeed = clampSpeed;
          }
          //public int A;
          //public double A;
          //public short A;
          //public byte A;
     }
}


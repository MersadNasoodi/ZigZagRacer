using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRotation : MonoBehaviour
{
    public Transform car;
    public void TurnRight()
    {
       car.transform.Rotate(new Vector3(0, +90, 0));

    }

    public void TurnLeft()
    {

        car.transform.Rotate(new Vector3(0, -90, 0));
    }
}

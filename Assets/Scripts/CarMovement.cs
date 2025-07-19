using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed;

    private float timer = 0;
    private bool isStep1 = false;
    private bool isStep2 = false;
    private bool isStep3 = false;
    private bool isStep4 = false;
    private bool isStep5 = false;


    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        timer += Time.deltaTime;
        if (!isStep1 && timer >= 15f)
        {
            speed += 2f;
            isStep1 = true;
        }

        if (!isStep2 && timer >= 30f)
        {
            speed += 2f;
            isStep2 = true;
        }

        if (!isStep3 && timer >= 45f)
        {
            speed += 2f;
            isStep3 = true;
        }


        if (!isStep4 && timer >= 60f)
        {
            speed += 2f;
            isStep4 = true;
        }

        if (!isStep5 && timer >= 75f)
        {
            speed += 2f;
            isStep5 = true;
        }


    }


}

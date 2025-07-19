using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public Transform car;

    private void Update()
    {
        if (car.transform.position.y < -3f)
            SceneManager.LoadScene(0);
    }



}

using UnityEngine;
using System.Collections;
using TMPro;

public class Enviornment : MonoBehaviour
{

    public TMP_Text timeText;
    public TMP_Text recordText;
    public GameObject newRecAnim;

    public Transform startPos;
    private Vector3 spawnPos;

    public GameObject cubePrefab;

    private const float step = -5f;


    private float spawnInterval = 0.5f;


    private Vector3 lastCubePos;

    private float timer = 0;
    private bool isStep1 = false;
    private bool isStep2 = false;
    private bool isStep3 = false;
    private bool isStep4 = false;
    private bool isStep5 = false;


    private void Start()
    {
        lastCubePos = startPos.position;

        StartCoroutine(SpawnRoutine());
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (!isStep1 && timer >= 15f)
        {
            spawnInterval = 0.4f;
            isStep1 = true;
        }

        if (!isStep2 && timer >= 30f)
        {
            spawnInterval = 0.35f;
            isStep2 = true;
        }

        if (!isStep3 && timer >= 45f)
        {
            spawnInterval = 0.3f;
            isStep3 = true;
        }

        if (!isStep4 && timer >= 60f)
        {
            spawnInterval = 0.25f;
            isStep4 = true;
        }

        if (!isStep5 && timer >= 75f)
        {
            spawnInterval = 0.2f;
            isStep5 = true;
        }

        timeText.text = Mathf.RoundToInt(timer).ToString();

        int savedProgress = PlayerPrefs.GetInt("HighestScore");

        if (Mathf.RoundToInt(timer) > savedProgress)
        {
            PlayerPrefs.SetInt("HighestScore", Mathf.RoundToInt(timer));
            PlayerPrefs.Save();
            newRecAnim.SetActive(true);
        }
        recordText.text = PlayerPrefs.GetInt("HighestScore").ToString();
    }


    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            SpawnCube();
            yield return new WaitForSeconds(spawnInterval);
        }
    }


    private void SpawnCube()
    {
        bool moveInX = Random.value < 0.5f;

        spawnPos = lastCubePos + (moveInX ? new Vector3(step, 0, 0)
                                          : new Vector3(0, 0, step));


        Instantiate(cubePrefab, spawnPos, Quaternion.identity);


        lastCubePos = spawnPos;
    }
}

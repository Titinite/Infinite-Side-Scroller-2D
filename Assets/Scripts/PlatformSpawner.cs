using System.Collections;
using UnityEngine;
using TMPro;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject prefabSpawn;
    private int randomY;
    private int randomScale;
    private float randomSecond;
    public TMP_Text scoreText;
    public int score = 0;

    void Start()
    {
        StartCoroutine(SpawnObjectInRandomSeconds());
    }

    IEnumerator SpawnObjectInRandomSeconds()
    {
        while(true)
        {
            score++;
            scoreText.text = "Score: " + score;

            randomY = Random.Range(-1, 2);
            randomScale = Random.Range(3, 5);
            SpawnGameObject(randomY, randomScale);

            randomSecond = Random.Range(1f, 2f);
            yield return new WaitForSeconds(randomSecond);
        }
    }


    void SpawnGameObject(int coord_y, int scale)
    {
        GameObject spawnedPrefab = Instantiate(prefabSpawn);
        spawnedPrefab.transform.position = new Vector3(18, coord_y, 0);
        spawnedPrefab.transform.localScale = new Vector3(scale, 1, 1);
    }

    void Update()
    {
        
    }
}
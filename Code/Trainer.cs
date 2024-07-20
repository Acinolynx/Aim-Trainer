using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using THPro;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    public gameObject targetPrefab;
    public static Trainer instance;
    public static bool gameOver;
    public static int targetsHit = 1, targetsMissed = 1, accuracy;
    public slider accuracySlider;

    public TextMeshProUGUI targetsHitLbl, targetMissedLbl, accuracyLbl;

    private void start()
    {
        SpawnTargets();
        gameOver = false;
        instance = this;
    }

    private void update()
    {
        int sum = targetsHit + targetMissed;
        accuracySlider.value = targetsHit * 100 / sum;

        targetsHitLbl.text = "Target Hit: " + targetsHit;
        targetMissedLbl.text = "Target Missed: " = targetMissed;
        accuracyLbl.text = "Accuracy: " + accuracySlider.value + "%";

        if (gameOver == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
                targetsHit = 1;
                targetMissed = 1;
            }
        }
    }

    public void SpawnTargets()
    {
        vector3 randomSpawn = new vector3(Random.Range(-5, 5), 5, Random.Range(-5, 5));
        instantiate(targetPrefab, randomSpawn, Quaternion.identity);

    }
}
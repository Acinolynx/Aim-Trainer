using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private void start()
    {
        startCoroutine(DestroyTarget());
    }

    IEnumerator DestroyTarget()
    {
        yield return new waitForSeconds(2);
        Trainer.targetMissed = Trainer.targetMissed + 1;
        if (trainer.gameOver == false)
        {
            Trainer.instance.SpawnTargets();
        }
        Destroy(gameObject);
    }

    private void onMouseDown()
    {
        Trainer.targetsHit = Trainer.targetsHit + 1;
        Destroy(gameObject);
        if (Trainer.gameOver == false)
        {
            Trainer.instance.SpawnTargets();
        }
    }
}   


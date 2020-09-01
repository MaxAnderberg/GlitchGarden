﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;
    [SerializeField] GameObject winLabel;
    [SerializeField] float waitToLoad = 2f;
    [SerializeField] GameObject loseLabel;

    private void Start()
    {
        winLabel.SetActive(false);
        loseLabel.SetActive(false);
    }
    public void AttackerSpawned()
    {
        numberOfAttackers++;

    }

    public void AttackerKilled()
    {
        numberOfAttackers--;
        if (numberOfAttackers <= 0 && levelTimerFinished)
        {

            StartCoroutine(HandleWinCondition());
        }
    }

    public void HandleLoseCondition()
    {
        loseLabel.SetActive(true);
        Time.timeScale = 0;
    }

    IEnumerator HandleWinCondition()
    {
        winLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(waitToLoad);
        FindObjectOfType<Level>().LoadNextScene();

    }
    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }


}

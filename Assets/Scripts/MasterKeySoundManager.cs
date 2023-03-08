using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterKeySoundManager : MonoBehaviour
{
    Transform playerTransform;
    public float maxVolume = 1f;
    public float maxDistance = 10f;

    private AudioSource audioSource;

    void Start () {
        audioSource = GetComponent<AudioSource>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update () {
        if(GameManager.Instance.IsPaused) {
            audioSource.volume = 0;
            return;
        }
        float distance = Vector3.Distance(transform.position, playerTransform.position);
        float volume = Mathf.Clamp(maxVolume * (1 - distance / maxDistance), 0f, maxVolume);
        audioSource.volume = volume;
    }
} 
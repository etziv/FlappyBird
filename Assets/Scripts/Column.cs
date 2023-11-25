using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    public AudioClip pointScore;
    private AudioSource point;

    void Start()
    {
        point = gameObject.AddComponent<AudioSource>();
        point.clip = pointScore;
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<Bird>() != null)
        {
            GameController.instance.BirdScored();
            point.Play();
        }
    }
}

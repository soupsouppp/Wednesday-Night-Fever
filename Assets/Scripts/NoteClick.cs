using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteClick : MonoBehaviour
{
    public bool canBeHit;
    Score playerscore;
    public GameObject score;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "HitLine")
        {
            canBeHit = true;

        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "HitLine")
        {
            canBeHit = false;
        }
    }


    void Update()
    {
        if (canBeHit && Input.GetMouseButtonDown(0))
        {
            Debug.Log("clicking left");
            gameObject.SetActive(false);
            Destroy(this.gameObject);
            playerscore.scoreCount += 1;
        }
    }

    void Start()
    {
        playerscore = score.GetComponent<Score>();
    }
}

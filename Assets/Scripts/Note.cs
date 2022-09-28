using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    public bool canBeHit;

    
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
        if (canBeHit && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("hitting space key");
            gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}

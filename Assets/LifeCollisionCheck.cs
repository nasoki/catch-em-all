using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCollisionCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player") && Score.life < 3)
        {
            Score.life++;
            GameObject.Find("Player").transform.Translate(0, -1, 0);
            Destroy(gameObject);
        }
        else if (collision.collider.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoment : MonoBehaviour
{
    public float bulletspeed;
    //AudioSource source;
   // ScoreManager ScoreManager;
    // Start is called before the first frame update
    void Start()
    {
        //source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(bulletspeed,0,0);
    }
   /* private void OnTriggerEnter2D(Collider2D collision)
    {

        if(gameObject.tag=="Astroid")
        {
            Destroy(gameObject);
            ScoreManager.Score(10);
           // source.Play();
        }
    }*/
}


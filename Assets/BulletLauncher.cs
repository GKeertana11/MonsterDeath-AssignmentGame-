using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
  // AudioSource source;
  //  public AudioClip audioClip;


    public Vector3 offset;
    void Start()
    {
       
        //source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))

        {
            Instantiate(bulletPrefab, transform.position + offset, Quaternion.identity);
            
           // source.Play();
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour

    
{
    public AudioSource tickSource;
    private Transform destination;

    public bool isOrange;
        public float distance = 0.2f;


    // Start is called before the first frame update
    void Start()
    {
        if(isOrange == false)
        {
            destination = GameObject.FindGameObjectWithTag("orange portal").GetComponent<Transform>();
        } else
        {
            destination = GameObject.FindGameObjectWithTag("blue portal").GetComponent<Transform>();
        }
    tickSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)

    {

    tickSource.Play();
        if (Vector2.Distance(transform.position, other.transform.position) > distance)
        {
            other.transform.position = new Vector2 (destination.position.x, destination.position.y);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    public float time;
    public AudioSource explosionSound;
    public AudioClip audioClipBomb;


    // Start is called before the first frame update
    void Start()
    {
        explosionSound = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(bulletSpeed, 0, 0);

        time = time + Time.deltaTime;
        if (time > 3.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            Destroy(collision.gameObject);
            explosionSound.clip = audioClipBomb;
            explosionSound.Play();
            GameObject.Find("ScoreManager").GetComponent<ScoreScript>().Score(5);
        }
    }
}
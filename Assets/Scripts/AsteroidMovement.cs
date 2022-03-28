using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsteroidMovement : MonoBehaviour
{
    public float AsteroidSpeed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * AsteroidSpeed * Time.deltaTime);
        transform.Rotate(90.0f * AsteroidSpeed * Time.deltaTime, 0f, 0f, Space.Self);
        if (transform.position.x < -12.0f)
        {
            Destroy(gameObject, 3.0f);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SpaceShip")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
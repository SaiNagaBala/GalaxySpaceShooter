using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;

    // Update is called once per frame
    public void Score(int score)
    {
        score = score + 10;
        Debug.Log(score);
    }
}
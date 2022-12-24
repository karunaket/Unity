using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text textscore;
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
        textscore.text = "KILLS : " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textscore.text = "KILLS : " + score.ToString();
    }
}

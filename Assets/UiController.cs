using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField] Text ptText;
    [SerializeField] Text timeText;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        ptText.text = "Pt: " + GameManager.Instance.Score;
        var time = 60 - (int) (Time.time - GameManager.Instance.StartTime);
        timeText.text = string.Format("{0:00}", time % 60);

        if(time <= 0) 
        {
            GameManager.Instance.GameEnd();
        }
    }
}

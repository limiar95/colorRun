using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static float score;
    public static bool isTime;
    private float time;

    void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        isTime = true;
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (isTime)
            time += Time.deltaTime;

        GameObject.Find("ScoreText").GetComponent<Text>().text = "Score: " + score.ToString();
        OnGui();        
	}

    void OnGui()
    {
        int minutes = (int)time / 60;
        int seconds = (int)time % 60;
        GameObject.Find("TimeText").GetComponent<Text>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}

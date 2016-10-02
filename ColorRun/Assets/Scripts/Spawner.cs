using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    private float delay;
    private float currentTime, velocityTime;
    [SerializeField]
    private GameObject[] bolas;
    public float gameVelocity;

	// Use this for initialization
	void Start () {
        delay = 0.5f;
        currentTime = 0.0f;
        velocityTime = 0.0f;
        gameVelocity = 10.0f;
    }
	
	// Update is called once per frame
	void Update () {

        if (currentTime >= delay)
        {
            currentTime = 0.0f;
            if (velocityTime > 20.0f)
            {
                gameVelocity += 2.0f;
                velocityTime = 0.0f;
            }

                Bola.createBall(bolas, ChooseNextBall(), gameVelocity);            
        }
        currentTime += Time.deltaTime;
        velocityTime += Time.deltaTime;
    }

    int ChooseNextBall()
    {
        int range = 0;
        int i;
        for (i = 0; i < bolas.Length; i++)
            range += bolas[i].GetComponent<Bola>().peso;

        var rand = Random.Range(0, range);
        var top = 0;

        for (i = 0; i < bolas.Length; i++)
        {
            top += bolas[i].GetComponent<Bola>().peso;
            if (rand < top)
                return i;
        }
        return -1;
    }
}

using UnityEngine;
using System.Collections;

public class Bola : MonoBehaviour {

    public float velocity;
    [SerializeField]
    private float points;
    [SerializeField]
    private Color cor;
    public int peso;

	// Use this for initialization
	public virtual void Start () {
        var pos = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0.1f, 0.9f), 1.0f, 10.0f));
        transform.position = new Vector3(pos.x, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, velocity * Time.deltaTime, 0));     
	}

    public void setVelocity(float value)
    {
        this.velocity = value;
    }

    public float getVelocity()
    {
        return velocity;
    }

    public void setCor(Color cor)
    {
        GetComponent<Renderer>().material.color = new Color(cor.r, cor.g, cor.b, cor.a);
    }
    
    public Color getCor()
    {
        return cor;
    }

    public float getPoints()
    {
        return points;
    }

    public static GameObject createBall(GameObject[] bolas, int ball, float gameVelocity)
    {
        GameObject bolaCriada = GameObject.Instantiate(bolas[ball], Vector3.zero, Quaternion.identity) as GameObject;
        bolaCriada.GetComponent<Bola>().setVelocity(gameVelocity);
        GameObject.Destroy(bolaCriada, 2.0f);
        return bolaCriada;
    }

}

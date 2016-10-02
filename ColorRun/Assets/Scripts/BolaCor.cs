using UnityEngine;
using System.Collections;

public class BolaCor : Bola {

    private Bola bola;
    private Color[] cores = { Color.red, Color.yellow, Color.green };

    void Start()
    {
        base.Start();
        bola = GetComponent<Bola>();
        bola.setCor(cores[Random.Range(0, cores.Length)]);
    }

    void OnMouseDown()
    {
        GameManager.score =  (GameManager.score + bola.getPoints());
        Destroy(gameObject);
    }

    void OnDestroy()
    {
        if (GameManager.score > 0)
            GameManager.score -= 10;
    }

}

using UnityEngine;
using System.Collections;

public class BolaCizenta : Bola {

    private Bola bola;

    void Start()
    {
        base.Start();
        bola = GetComponent<Bola>();
        bola.setCor(GetComponent<Bola>().getCor());
    }

     void OnMouseDown()
    {
        GameManager.score = 0;
        Destroy(gameObject);
    }

}

using UnityEngine;
using System.Collections;

public class BolaPreta : Bola {

    private Bola bola;

    void Start()
    {
        base.Start();
        bola = GetComponent<Bola>();
        bola.setCor(GetComponent<Bola>().getCor());
    }

    void OnMouseDown()
    {
        Time.timeScale = 0;
        GameManager.isTime = false;
    }
}

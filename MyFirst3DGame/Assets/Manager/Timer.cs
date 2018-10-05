using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float maxTime = 60f;

    private float countDown = 0f;

    // Use this for initialization
    void Start () {
        countDown = maxTime;
		
	}
	
	// Update is called once per frame
	void Update () {
        // El deltatime es el tiempo que ha pasado desde la última renderización en pantalla del frame anterior.

        countDown -= Time.deltaTime; // esto es igual que poner -> countDown = countDown - Time.deltaTime;

        Debug.Log(countDown);

        if (countDown <= 0)
        {
            Debug.Log("Te has quedado sin tiempo. Game Over");

            Coin.coinsCount = 0;
            SceneManager.LoadScene("TerrenoPrincipal");

        }
	}
}

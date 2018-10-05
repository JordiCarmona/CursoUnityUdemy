using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{

    //Variable global y estática (una para todas las monedas)
    public static int coinsCount = 0;



	// Use this for initialization
	void Start ()
    {
        Coin.coinsCount++;
        Debug.Log("El juego ha comenzado y hay " + Coin.coinsCount + " monedas");
    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    /*
     * MÉTODO QUE PERMITE DETECTAR LA COLISIÓN DE UN COLLIDER
     * CON EL COLLIDER DE ESTE MÉTODO (LA MONEDA).
     */
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Player") == true)
        {
            Coin.coinsCount--;
            Debug.Log("Hemos recogido una moneda y ahora hay " + Coin.coinsCount + " monedas");
            if (Coin.coinsCount == 0)
            {
                Debug.Log("El juego ha terminado, no hay monedas.");

                GameObject gameManager = GameObject.Find("GameManager");
                Destroy(gameManager);

                GameObject[] fireworksSystem = GameObject.FindGameObjectsWithTag("FinalFireworks");
                foreach (GameObject fireworks in fireworksSystem) {
                    fireworks.GetComponent<ParticleSystem>().Play();
                }
            }
            Destroy(gameObject);
        }
        
    }
}

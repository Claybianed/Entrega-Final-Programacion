using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private GameObject[] enemies;
    [SerializeField] Text numEnemiesTxt;
    private int numEnemies;

    // Start is called before the first frame update
    void Start()
    {
        
        enemies = GameObject.FindGameObjectsWithTag("Enemigo");
        numEnemies = enemies.Length;

    }

    // Update is called once per frame
    void Update()
    {
        

        Debug.Log("La cantidad de enemigos es: " + numEnemies);

        if (numEnemies == 0)
        {
            Debug.Log("bien");
        }

        TextoNumEnemies();
    }

    public void ReducirNumEnemigos()
    {
        numEnemies = numEnemies - 1;
    }

    void TextoNumEnemies()
    {

        numEnemiesTxt.text = numEnemies.ToString();

    }

}

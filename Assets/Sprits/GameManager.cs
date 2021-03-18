using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class GameManager : MonoBehaviour
{
    public Renderer fondo;
    public GameObject nube1;

    public GameObject menuPrincipal;
    public GameObject menuGameOver;

    public bool gameOver = false;
    public bool start = false;

    public List<GameObject> nubes;
    // Start is called before the first frame update

    //Codigo Ricky

    void Start()
    {
        //Creacion de Nubes
        nubes.Add(Instantiate(nube1, new Vector2(14, -2), Quaternion.identity));
        nubes.Add(Instantiate(nube1, new Vector2(18, 0), Quaternion.identity));
        nubes.Add(Instantiate(nube1, new Vector2(20, 2), Quaternion.identity));

    }

    // Update is called once per frame
    void Update()
    {
        if (start == false)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                start = true;
            }
        }

        if (start == true && gameOver == true)
        {
            menuGameOver.SetActive(true);
            if (Input.GetKeyDown(KeyCode.X))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        //Condicional para inicializar el juego. Nota: Todo el codigo del juego se debe poner dentro.

        if (start == true && gameOver == false)
        {

            menuPrincipal.SetActive(false);


        }

 
        //Mover Map
        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.02f, 0) * Time.deltaTime;

        //Mover Nubes
        for(int i = 0; i<nubes.Count; i++)
        {
            
            if(nubes[i].transform.position.x <= -10)
            {
                float randomObs = Random.Range(10, 20);
                float randomObs1 = Random.Range(-2, 7);
                nubes[i].transform.position = new Vector3(randomObs, randomObs1, 0);
            }

            nubes[i].transform.position = nubes[i].transform.position + new Vector3(-1, 0, 0) * Time.deltaTime * 2; 
        }

        

    }
}

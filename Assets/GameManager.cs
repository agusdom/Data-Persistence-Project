using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.SearchService;

public class GameManager : MonoBehaviour
{
    public Text counterText;
    public Text lifeText;
    public Text winText;
    public Button restart;
    [SerializeField] GameObject sphere;
    private Lifes lifes;
    private Sphere spheree;
    private int Count;

    // Start is called before the first frame update
    void Start()
    {
        spheree = GameObject.Find("Sphere").GetComponent<Sphere>();
        lifes = GetComponent<Lifes>();
        InvokeRepeating("SpawnBall", 0,4);
        lifeText.text = "Lives:" + lifes.life;
        Count = 0;


    }

    // Update is called once per frame
    void Update()
    {
        LostGame();
        WinGame();
    }

    void SpawnBall()
    {
        if (spheree.ballisActive == false && !GameObject.Find("Sphere") && lifes.life > 0 && Count < 5)
        {
            Instantiate(sphere, gameObject.transform.position, gameObject.transform.rotation);
            
        }
        spheree.ballisActive = true;
    }
    public void CounterPoint()
    {
        Count = Count + 1;
        counterText.text = "Count : " + Count;


    }
    public void LostGame()
    {
        if (lifes.life <= 0)
        {
            lifes.LostText.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);


        }

    }
    public void WinGame()
    {
        if (Count == 5)
        {
            winText.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
        }

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

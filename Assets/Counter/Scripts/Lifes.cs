using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;
using UnityEngine.UI;
public class Lifes : MonoBehaviour
{
    public Text LostText;
    public int life;
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
        life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LostLife()
    {
        life = life - 1;
        gm.lifeText.text = "Lives:" + life;

    }

   
}

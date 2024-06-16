using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Using
using TMPro;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour
{
    //Variables being used
    public TextMeshProUGUI TimeText;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        var timeToDisplay = PlayerPrefs.GetFloat("highscore");

        var t0 = (int)timeToDisplay;
        var m = t0 / 60;
        var s = (t0 - m * 60);
        var ms = (int)((timeToDisplay - t0) * 100);

        TimeText.text = $"{m:00}:{s:00}:{ms:00}";

        gameObject.transform.Rotate(0, 0, -300 * Time.deltaTime);
    }

    //Triggers
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("block"))
        {
            collision.GetComponent<SpriteRenderer>().color = gameObject.GetComponent<SpriteRenderer>().color;
        }
    }

    //Buttons
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }
}

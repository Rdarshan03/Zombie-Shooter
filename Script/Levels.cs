using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Levels : MonoBehaviour
{

    public Button[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        print(GetComponentsInChildren<Canvas>().Length);
    }


    // Update is called once per frame
    void Update()
    {
             
    }

    private void OnEnable()
    {
        for (int i = 0; i < buttons.Length; i++)
        {   
            int k = i;
            buttons[i].GetComponentInChildren<Text>().text = "" + (i + 1);
            buttons[i].onClick.AddListener(() =>
            {
                //print("clickbutton" + k);
                PlayerPrefs.SetInt("level", k + 1);
                SceneManager.LoadScene("Lvl" + (k + 1));

            });
        }
    }
    public void Backbtn()
    {
        SceneManager.LoadScene("Level");
    }
    public void Replaybtn()
    {
        int lv = PlayerPrefs.GetInt("level");
        PlayerPrefs.SetInt("level", (lv - 1));
        SceneManager.LoadScene("lvl" + (lv - 1));
    }
    public void Nextbtn()
    {
        int levl = PlayerPrefs.GetInt("level");
        SceneManager.LoadScene("lvl" + levl);
    }
    public void Retrybtn()
    {
        int lv = PlayerPrefs.GetInt("level");
        PlayerPrefs.SetInt("level", lv);
        SceneManager.LoadScene("lvl" + lv);
    }


}

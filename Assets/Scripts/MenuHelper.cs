using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHelper : MonoBehaviour
{

    private GameObject input;
    private string name;
    void Start()
    {
        input = GameObject.Find("InputText");

        if (PlayerPrefs.GetString("name") != null)
        {
            name = PlayerPrefs.GetString("name");
            GameObject.Find("InputNameText").GetComponent<TextMeshProUGUI>().text = "Welcome back " + name + "!";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateName()
    {
        name = input.GetComponent<TextMeshProUGUI>().text;
        PlayerPrefs.SetString("name", name);

    }

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }
}

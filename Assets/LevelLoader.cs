using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public Button Button;
    public Animator transition;
    public float TransitionTime = 1f;

    void Start()
    {
        Button btn = Button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
    }
    void TaskOnClick()
    {
        LoadNextLevel();
    }
}

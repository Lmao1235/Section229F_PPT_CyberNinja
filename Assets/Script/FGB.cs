using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FGB : MonoBehaviour
{
    [SerializeField] private int SceneBuild;

    private void Start()
    {


    }
    public void Goback()
    {

        SceneManager.LoadScene(SceneBuild, LoadSceneMode.Single); //��Ѻ�˹�� Menu
    }
}

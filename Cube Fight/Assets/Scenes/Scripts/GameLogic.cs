using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    private bool playGame = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Escape) && playGame ) {
            Load.sceneNum = 0;
            SceneManager.LoadScene(1);
        }
    }


}

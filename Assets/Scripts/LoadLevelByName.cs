using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelByName : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadLevel(string nextLevel)
    {
        SceneManager.LoadScene(nextLevel);
    }    
}

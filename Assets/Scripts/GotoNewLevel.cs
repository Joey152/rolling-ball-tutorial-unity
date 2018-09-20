using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNewLevel : MonoBehaviour {

    public Transform t;
    int level = 0;

    void FixedUpdate()
    {
        shouldLevelChange();
    }

    void changeLevel()
    {
        SceneManager.LoadScene("Level" + ++level);
    }

    public void shouldLevelChange()
    {
        if (t.childCount == 0)
        {
            changeLevel();
        }
    }
}

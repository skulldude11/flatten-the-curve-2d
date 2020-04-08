using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOnCollision : MonoBehaviour
{

    [SerializeField]
    string strTag;

    [SerializeField]
    string strSceneName;

   
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == strTag)
            SceneManager.LoadScene(strSceneName);
    }
}

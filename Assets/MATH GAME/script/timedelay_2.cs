using UnityEngine;
using System.Collections;

public class timedelay_2 : MonoBehaviour
    {
    private float counter;
    // Use this for initialization


    // Update is called once per frame
    void Update()
        {
        counter += Time.deltaTime;
        if (counter > 3)
            {
            UnityEngine.SceneManagement.SceneManager.LoadScene("sc3");
            }
        }
    }

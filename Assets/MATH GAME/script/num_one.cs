using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class num_one : MonoBehaviour
    {

    public Text hit;

    void OnCollisionEnter(Collision col)
        {
        if (col.gameObject.CompareTag("hitter"))
            {

            hit.text += "1";

            }
        }

}

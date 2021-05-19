using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LatihanTrigger : MonoBehaviour
{
    public GameObject Pertanyaan_1;
    public bool aktif;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "TrafficSign1")
        {
            Pertanyaan_1.SetActive(aktif);
        }

        if (other.gameObject.name == "Gedung Finish")
        {
            SceneManager.LoadScene("HasilPermainan");
        }
    }
}

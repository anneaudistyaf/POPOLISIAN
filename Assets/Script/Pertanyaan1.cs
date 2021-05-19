using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pertanyaan1 : MonoBehaviour
{
    public GameObject Pertanyaan_1;
    public bool aktif;

    public void AnswerTrue()
    {
        Pertanyaan_1.SetActive(false);
    }
}

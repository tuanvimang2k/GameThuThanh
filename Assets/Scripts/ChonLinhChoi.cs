﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChonLinhChoi : MonoBehaviour
{

    private static ChonLinhChoi instance;
    public static ChonLinhChoi Instance { get => instance; set => instance = value; }

    public ListLinhChonChoi listLinhChonChoi;

    public static bool linh1;
    public static bool linh2;
    public static bool linh3;

    public SavingFile savingFile;
    // Start is called before the first frame update
    void Start()
    {

        savingFile = GameObject.Find("SaveData").GetComponent<SavingFile>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Linh1()
    {
        linh1 = true;

    }

    public void Linh2()
    {
        linh2 = true;

    }
    public void Linh3()
    {
        linh3 = true;

    }

    public void ChonLinh1()
    {
        ChonLinh(1);

    }
    public void ChonLinh2()
    {
        ChonLinh(2);

    }
    public void ChonLinh3()
    {
        ChonLinh(3);

    }
    public void ChonLinh4()
    {
        ChonLinh(4);

    }
    public void ChonLinh5()
    {
        ChonLinh(5);

    }
    public void ChonLinh6()
    {
        ChonLinh(6);

    }
    public void ChonLinh7()
    {
        ChonLinh(7);

    }
    public void ChonLinh8()
    {
        ChonLinh(8);

    }
   

    public void ChonLinh(int soLinh)
    {
        if (linh1 == true)
        {
            if (soLinh == SavingFile.solider2 || soLinh == SavingFile.solider3) Debug.Log("Lính đã tồn tại");
            else
            {
                SavingFile.solider1 = soLinh;
                linh1 = false;
                Debug.Log("Ô 1 lính bằng : " + soLinh);
            }
        }
        if (linh2 == true)
        {
            if (soLinh == SavingFile.solider1 || soLinh == SavingFile.solider3) Debug.Log("Lính đã tồn tại");
            else
            {
                SavingFile.solider2 = soLinh;
                linh2 = false;
                Debug.Log("Ô 2 lính bằng : " + soLinh);
            }
        }
        if (linh3 == true)
        {
            if (soLinh == SavingFile.solider1 || soLinh == SavingFile.solider2) Debug.Log("Lính đã tồn tại");
            else
            {
                SavingFile.solider3 = soLinh;
                linh3 = false;
                Debug.Log("Ô 3 lính bằng : " + soLinh);
            }
        }
        listLinhChonChoi.ListLinh();

    }
}

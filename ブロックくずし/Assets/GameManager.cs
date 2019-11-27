using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int column = 5, row = 4;
    int p = 0;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        SetBlock();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N))
        {
            SetBlock();
        }
    }

    void SetBlock()
    {
        int m = column;
        int n = row;

        if (p == 2) Instantiate(obj, new Vector3(0.0f, 0.0f, 8.0f + 2.0f), Quaternion.identity);
        if (m > 5 || m < 1 || n < 1 || n > 8) throw new System.FormatException();
        if (m % 2 == 0)
        {
            p = 1;
            m /= 2;
        } else { m = (m + 1) / 2; }

        for (int s = 0; s < n; s++)
        {
            if (s > 0) Instantiate(obj, new Vector3(0.0f, 0.0f, 8.0f + s * 2.0f), Quaternion.identity);
            for (int i = 1; i < m; i++)
            {
                Instantiate(obj, new Vector3(i * 4.0f, 0.0f, 8.0f + s * 2.0f), Quaternion.identity);
                Instantiate(obj, new Vector3(i * -4.0f, 0.0f, 8.0f + s * 2.0f), Quaternion.identity);
            }
            if (p == 1)
            {
                Instantiate(obj, new Vector3(m * 4.0f, 0.0f, 8.0f + s * 2.0f), Quaternion.identity);
            }
        }
        p = 2;
    }
}

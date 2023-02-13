using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secenegeneration : MonoBehaviour
{
    public GameObject[] section;
    public float zpos = 32;
    public bool createSection = false;
    public int secNum = 9; 

    void Update()
    {
        if (createSection == false)
        {
            createSection = true;
            StartCoroutine(GenerateSection());
        }    
    }
    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0, 0, zpos), Quaternion.identity);
        zpos += 283;
        yield return new WaitForSeconds(13);
        createSection = false;

    }
}

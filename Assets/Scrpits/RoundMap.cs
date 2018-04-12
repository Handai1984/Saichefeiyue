
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundMap : MonoBehaviour
{
    public GameObject[] roadList;//加载不同的路


	void Start ()
	{
        ChangerRoad();
        
	}

    private void ChangerRoad()
    {
        int temp = roadList.Length;
        int rnd = Random.Range(0, temp);
        
            Instantiate(roadList[rnd], transform.position, Quaternion.identity);
        
    }
}

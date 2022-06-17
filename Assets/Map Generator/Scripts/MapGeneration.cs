using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    GameObject player;
    GameObject[] env;
    [SerializeField] GameObject[] options;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        env = GameObject.FindGameObjectsWithTag("Map");
    }

    // Update is called once per frame
    void Update()
    {
        int objNum = 0;
        if(env.Length != 0)
        {
            foreach(GameObject mapObj in env)
            {
                if(Vector3.Distance(player.transform.position, mapObj.transform.position) < 15)
                {
                    objNum++;
                }
            }
        }
        
        while(objNum < 10)
        {
            Vector3 objPos = new Vector3(Random.Range(-10f, 10f), Random.Range(-5f, 5f), 0);
            GameObject obj = GameObject.Instantiate(options[Random.Range(0, options.Length)], player.transform.position + objPos, Quaternion.identity);
            obj.transform.SetParent(gameObject.transform);
            objNum++;
            env = GameObject.FindGameObjectsWithTag("Map");
        }
    }
}

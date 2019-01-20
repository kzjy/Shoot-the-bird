using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

    public Vector3 center;
    public Vector3 size;
    public GameObject spawn1;
    public GameObject spawn2;
    Vector3 rotation1 = new Vector3(0, 90, -10);
    Vector3 rotation2 = new Vector3(0, -90, 10);
    Vector3 actualrotation;
    public float speed;
    private GameObject spawnclone;
    float spawntimer = 0;

    // Use this for initialization
    void Start()
    {

        //InvokeRepeating("Spawnstuff", 0, 1);

        if (gameObject.name == "leftspawn")
        {
            actualrotation = rotation1;
        }
        else
        {
            actualrotation = rotation2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (spawntimer <= 0.2)
        {
            spawntimer += Time.deltaTime;
        }
        else
        {
            spawntimer = 0;
            Spawnstuff();
        }
    }

    public void Spawnstuff()
    {
        Vector3 pos = new Vector3(Random.Range(center.x - size.x / 2, center.x + size.x / 2), Random.Range(center.y - size.y / 2, center.y + size.y / 2), Random.Range(center.z - size.z / 2, center.z + size.z / 2));
        int spawnthing = Random.Range(0, 2);
        
        GameObject actualspawn = spawn1;
       
        if (spawnthing == 1)
        {
            actualspawn = spawn2;
        }
        spawnclone = Instantiate(actualspawn, pos, Quaternion.Euler(actualrotation));
    }
}

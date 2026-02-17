using System.Collections;
using UnityEngine;

public class DonutBakerScript : MonoBehaviour
{
    public GameObject[] donutPrefabs;
    public float bakeInterval = 1.0f;
    public float offset = 0.7f;
    
    float minPoz, maxPoz;
    Transform ovenTransform;

    void Start()
{
        ovenTransform = GetComponent<Transform>();
        StartBaking();
}

    
    public void StartBaking()
    {
        StopAllCoroutines();
        StartCoroutine(Bake());
    }

    
    public void StopBaking()
    {
        StopAllCoroutines();
    }

IEnumerator Bake() {          
    while (true) {
        float minX = ovenTransform.position.x - offset;
        float maxX = ovenTransform.position.x + offset;
        float randX = Random.Range(minX, maxX);

        Vector3 spawnPoz = new Vector3(randX, ovenTransform.position.y, ovenTransform.position.z);

        if (donutPrefabs.Length > 0) {
            int donutIndex = Random.Range(0, donutPrefabs.Length);
            Instantiate(donutPrefabs[donutIndex], spawnPoz, Quaternion.identity);
        }

        yield return new WaitForSeconds(bakeInterval);
    }
}
}
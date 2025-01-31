using UnityEngine;

public class Bunny : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Feed() {
        Vector2 spawnPosition = transform.position;
        spawnPosition += Random.insideUnitCircle; //returns random vector2 within the unit circle
        Instantiate<GameObject>(gameObject, spawnPosition, Quaternion.identity);
        //identity Quaternion is the default (0 degree) rotation
    }
}

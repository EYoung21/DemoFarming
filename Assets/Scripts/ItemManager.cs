using Unity.VisualScripting;
using UnityEngine;

public class ItemManager : MonoBehaviour
{

    GameObject item; //if null, don't have one


    // bool hasCarrot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // if Pickable item and not already has carrot
        //     add item to PlayerScript

        Debug.Log(other.tag);

        if (other.tag == "Carrot" && item == null) {
            item = other.gameObject;
            item.transform.SetParent(transform);
            item.transform.localPosition = new Vector3(0.5f, 0, 0);
            Destroy(other); //other.enabled = false;
            Debug.Log("In trigger enter 2d");
        }

        Bunny bunny = other.GetComponent<Bunny>();

        if (bunny != null && item != null) {
            bunny.Feed();
            Destroy(item);
            item = null;
        }
    }
}

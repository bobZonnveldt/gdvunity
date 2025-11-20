using UnityEngine;

public class randomItem : MonoBehaviour
{
   
 [SerializeField] private GameObject[] spawnPoints = new GameObject[10];

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))PrintRandomItem();
        if(Input.GetKeyDown(KeyCode.KeypadEnter))PrintAllItems();
    }
    private void PrintRandomItem() {
        int i = Random.Range(0, spawnPoints.Length);
        Debug.Log("Random item: " + spawnPoints[i].name);

    }
    private void PrintAllItems() {
        foreach (GameObject item in spawnPoints) {
            Debug.Log("Item: " + item.name);
        }
    }

}
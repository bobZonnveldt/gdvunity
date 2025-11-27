using UnityEngine;

public class randomItem : MonoBehaviour
{
   
 [SerializeField] private GameObject[] spawnPoints = new GameObject[10];

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))PrintRandomItem();
        if(Input.GetKeyDown(KeyCode.Backspace))PrintAllItems();
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
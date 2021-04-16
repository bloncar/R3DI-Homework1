using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public interface ICollectionHandler
{
    void PlayerDidCollectItem(GameObject item);
}

public class GameManager : MonoBehaviour, ICollectionHandler
{
    private int numberOfCollectables;
    private int numberOfItemsCollected = 0;

    private int points = 0;

    public PlayerController Player;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        Player.collectionHandler = this;
        numberOfCollectables = GameObject.FindGameObjectsWithTag(Tags.Collectable).Length;

        uiManager.UpdatePoints(points);
    }

    public void PlayerDidCollectItem(GameObject item)
    {
        points += item.GetComponent<CoinController>().GetPoints();
        uiManager.UpdatePoints(points);
        Destroy(item);

        numberOfItemsCollected++;

        if (numberOfItemsCollected >= numberOfCollectables)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}

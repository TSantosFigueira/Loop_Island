using UnityEngine;
using System.Collections;

public class SpawnOnCollision : MonoBehaviour {
    public GameObject Controller;
    private GameObject[] ObjectToSpawn;
    private bool IsBusy;
    private GameObject ObjectSpawned;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        if (!IsBusy)
        {
            int PlayerCoins = Controller.GetComponent<CoinManager>().GetCoins();
            int CustoAtual= PlayerPrefs.GetInt("Custo");
            if (PlayerCoins >= CustoAtual)
            {
                ObjectToSpawn = Controller.GetComponent<ObjectsManager>().ObjectsToSpawn;
                int ObjectKey = PlayerPrefs.GetInt("SelectedObject");
                ObjectSpawned = Instantiate(ObjectToSpawn[ObjectKey]);
                if (ObjectSpawned)
                {
                    ObjectSpawned.gameObject.transform.SetParent(this.transform);
                    ObjectSpawned.transform.position = gameObject.transform.position;
                    Controller.GetComponent<CoinManager>().SetCoins(CustoAtual, false);
                    PlayerPrefs.SetInt("SelectedObject", 0);
                    PlayerPrefs.SetInt("Custo", 0);
                    IsBusy = true;
                    Debug.Log(Controller.GetComponent<CoinManager>().GetCoins());
                }
            }
        }
    }
}

using UnityEngine;
using System.Collections;

public class SpawnOnCollision : MonoBehaviour {
    public GameObject Controller;
    private GameObject[] ObjectToSpawn;
    private bool IsBusy;
    private GameObject ObjectSpawned;
  
    void OnMouseDown()
    {
        int ObjectKey = PlayerPrefs.GetInt("SelectedObject");
        if (!IsBusy)
        { 
            int PlayerCoins = Controller.GetComponent<CoinManager>().GetCoins();
            int CustoAtual= PlayerPrefs.GetInt("Custo");
            if (PlayerCoins >= CustoAtual && ObjectKey != 5)
            {
                ObjectToSpawn = Controller.GetComponent<ObjectsManager>().ObjectsToSpawn;
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
        else if (IsBusy)
        {         
            if(ObjectKey == 5)
            {
                IsBusy = false;
                Destroy(gameObject.transform.GetChild(0).gameObject);
            }
        }
    }
}

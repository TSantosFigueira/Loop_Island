using UnityEngine;
using System.Collections;

public class SpawnOnCollision : MonoBehaviour
{
    public GameObject Controller;
    public GameObject Direction;
    public float AngleCanhao;

    private GameObject[] ObjectToSpawn;
    private bool IsBusy;
    private GameObject ObjectSpawned;

    void OnMouseDown()
    {
        int ObjectKey = PlayerPrefs.GetInt("SelectedObject");
        if (!IsBusy)
        {
            int PlayerCoins = Controller.GetComponent<CoinManager>().GetCoins();
            int CustoAtual = PlayerPrefs.GetInt("Custo");
            if (PlayerCoins >= CustoAtual && ObjectKey != 5)
            {
                ObjectToSpawn = Controller.GetComponent<ObjectsManager>().ObjectsToSpawn;
                ObjectSpawned = Instantiate(ObjectToSpawn[ObjectKey]);
                if (ObjectSpawned)
                {
                    //AngleCanhao = this.transform.eulerAngles;
                    //AngleCanhao = Vector3.Distance(gameObject.transform.up, Direction.transform.position);
                    ObjectSpawned.gameObject.transform.SetParent(this.transform);
                    ObjectSpawned.transform.position = gameObject.transform.position;
                    ObjectSpawned.transform.localScale = new Vector3(1.3f, 1.2f, 0);
                    ObjectSpawned.transform.eulerAngles = new Vector3(0, 0, transform.rotation.eulerAngles.z +180);
                    //new Vector3(0, 0, AngleCanhao - 107);
                    ObjectSpawned.transform.position = ObjectSpawned.transform.position;
                    //Debug.Log(ObjectSpawned.transform.up);
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
            if (ObjectKey == 5)
            {
                IsBusy = false;
                Destroy(gameObject.transform.GetChild(0).gameObject);
            }
        }
    }
}
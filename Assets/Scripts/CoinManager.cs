using UnityEngine;
using System.Collections;

public class CoinManager : MonoBehaviour {
   public int InitialCoins=100;
    private int PlayerCoins;
	// Use this for initialization
	void Start () {
        PlayerCoins = InitialCoins;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public int GetCoins()
    {
        return PlayerCoins;
    }
    public void SetCoins(int CustoToAddOrDown,bool AddOrDown)
    {
        if(AddOrDown) PlayerCoins = PlayerCoins + CustoToAddOrDown;
        else PlayerCoins = PlayerCoins - CustoToAddOrDown;
    }
}

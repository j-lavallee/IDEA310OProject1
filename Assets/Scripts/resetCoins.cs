using UnityEngine;

public class resetCoins : MonoBehaviour
{
    [SerializeField]
    private CoinData CoinDataFloat;

    void Start()
    {
        Cursor.visible = false;
        CoinDataFloat.Value = 0;
    }

}

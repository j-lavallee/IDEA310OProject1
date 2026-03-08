using UnityEngine;
using TMPro;

public class coins : MonoBehaviour
{
    [SerializeField]
    private CoinData CoinDataFloat;
    public TextMeshProUGUI coinText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Coin")
        {
            CoinDataFloat.Value++;
            coinText.text = "Cool Rocks: " + CoinDataFloat.Value;
            Destroy(other.gameObject);
        }
    }

    private void Start()
    {
        coinText.text = "Cool Rocks: " + CoinDataFloat.Value;
    }
}

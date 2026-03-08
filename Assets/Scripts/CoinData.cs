using UnityEngine;

[CreateAssetMenu(fileName = "CoinData", menuName = "Scriptable Objects/CoinData")]
public class CoinData : ScriptableObject
{
    [SerializeField]
    private float _value;

    public float Value
    {
        get { return _value; }
        set { _value = value; }
    }
}

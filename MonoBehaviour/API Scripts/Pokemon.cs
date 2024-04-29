using UnityEngine;

[System.Serializable]
public class Crypto
{
    public string id;
    public string rank;
    public string symbol;
    public string name;
    public string supply;
    public string maxSupply;
    public string marketCapUsd;
    public string volumeUsd24Hr;
    public string priceUsd;
    public string changePercent24Hr;
    public string vwap24Hr;
    public string explorer;

    public Crypto(string id, string rank, string symbol, string name, string supply, string maxSupply, string marketCapUsd, string volumeUsd24Hr, string priceUsd, string changePercent24Hr, string vwap24Hr, string explorer)
    {
        this.id = id;
        this.rank = rank;
        this.symbol = symbol;
        this.name = name;
        this.supply = supply;
        this.maxSupply = maxSupply;
        this.marketCapUsd = marketCapUsd;
        this.volumeUsd24Hr = volumeUsd24Hr;
        this.priceUsd = priceUsd;
        this.changePercent24Hr = changePercent24Hr;
        this.vwap24Hr = vwap24Hr;
        this.explorer = explorer;
    }
}
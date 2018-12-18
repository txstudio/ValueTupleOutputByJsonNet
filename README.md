# 透過 JSON.NET 將 ValueTuple 序列化的主控台應用程式

其實只是想要看一下結果，(Product, ProductPrice) 會輸出如下

```
{
  "Item1": {
    "No": 1,
    "Schema": "MICROSOFTSURPRO6",
    "Name": "Surface Pro 6"
  },
  "Item2": {
    "AdvicePrice": 47000.0,
    "SellPrice": 45000.0,
    "PurchasePrice": 15000.0
  }
}
```

結果蠻普通的 ...

### 參考資料
- [C# 7.0 的 ValueTuple | 微軟開發工具資訊分享 - 點部落](https://dotblogs.com.tw/aspnetshare/2017/02/24/20170223-valuetuple)
- [ValueTuple Struct (System) | Microsoft Docs](https://docs.microsoft.com/zh-tw/dotnet/api/system.valuetuple)

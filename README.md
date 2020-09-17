# Navigering med Pages 
Det här exemplet bygger på tanken att man har en MainWView i form av ett fönster (Window). I detta fönster finns en yta där olika sidor (pages) laddas in.

```cs
<Frame x:Name="mainFrame" />
```

Vilken sida som laddas avgörs på lita olika sätt i exemplet. Men det smartaste kan eventuellt vara att använda ett Command som har en parameter. I det här fallet är parametern av typen enum.

```cs
<Button Command="{Binding NavigateToPageByParameterCommand}" CommandParameter="{x:Static local:ApplicationPage.PlayGame}" Content="Visa Sida 2 (med parameter)" />
```

Vad som sedan behövs är någon kod som ovandlar parametern till en konkret sida. Detta hanteras via en helper
```cs
NavigateToPageHelper
```
Som i sin tur har en statisk metod:
```cs
public static Page GetPage(ApplicationPage page, BaseViewModel model = null)
```

Den tar emot önskad sida som första parameter och eventuellt en specifik vymodell.


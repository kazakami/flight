# kzkm-engineの使い方サンプル的なものにするつもり

# 使い方
トップディレクトリ内にkzkm-engineのディレクトリをおいてください
```
$ dotnet run
```
で実行できます

# 各ターゲット向けのリリースビルド法

```
$ dotnet restore -r <ターゲットRID>
$ dotnet build -c Release
```

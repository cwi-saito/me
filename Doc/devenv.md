- nuget packageを取ってくるコマンド  
のまえにNugetパッケージ復元の有効化を行う（対象のslnで
```
cd {package.configが入っているフォルダ}
{nuget.exeのフルパス} restore -SolutionDirectory {対象のslnが入っているディレクトリ}
```

- devenvでビルド
```
cd {devenv.exeのパス}※PATH通してもOK
Devenv "対象のsln" /Rebuild debug /out {ログのパス}
参考
https://msdn.microsoft.com/ja-jp/library/xee0c8y7.aspx
```


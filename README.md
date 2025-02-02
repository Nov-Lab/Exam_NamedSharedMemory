﻿# 【.NET用サンプル】MemoryMappedFile を用いた共有メモリーの実装

複数のプロセスからアクセス可能な共有メモリーを MemoryMappedFile で実装するサンプルです。

ソースコードと実行結果を併せてご覧ください。

## サンプルのポイント

共有メモリーを使って内部の動作状況を常時公開し、別プロセスとして動作するデバッグ用プログラムからリアルタイムにモニタリングできる仕組みにしています。


## 関連プロジェクト

本プロジェクトを基にした [WPFサンプル](https://github.com/Nov-Lab/Exam_WPF) では、UI画面部分を WPF(Windows Presentation Foundation) で作成していますので、Windows フォームで作成している本プロジェクトとの動作の違いを比べることができます。


# 動作環境

- Windows 8.1以降
- .NET Framework 4.5.1 以降、または互換性のある .NET 実装


# ライセンス

本ソフトウェアは、MITライセンスに基づいてライセンスされています。


# 開発環境

## 開発ツール、SDKなど
- Visual Studio Community 2019
  - ワークロード：.NET デスクトップ開発

## 言語
- C#


# 変更履歴

- 2024/06/27：バージョン 0.5.0.1
  - 初版公開


# その他

Nov-Lab 独自の記述ルールと用語については [NovLabRule.md](https://github.com/Nov-Lab/Nov-Lab/blob/main/NovLabRule.md) を参照してください。

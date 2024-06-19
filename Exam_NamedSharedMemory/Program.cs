// @(h)Program.cs ver 0.00 ( '24.06.19 Nov-Lab ) 作成開始(自動生成)
// @(h)Program.cs ver 0.51 ( '24.06.22 Nov-Lab ) ベータ版完成
// @(h)Program.cs ver 0.52 ( '24.06.26 Nov-Lab ) 機能追加：デバッガーモードで起動されたとき、デバッガー動作中ミューテックスを生成するようにした

// @(s)
// 　【アプリケーションメイン】アプリケーションのメイン エントリ ポイントです。

using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;


namespace Exam_NamedSharedMemory
{
    static class Program
    {
        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【アプリケーションメイン】アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        /// <param name="args">[in ]：コマンドライン引数配列</param>
        //--------------------------------------------------------------------------------
        [STAThread]
        static void Main(string[] args)
        {
            //------------------------------------------------------------
            // (自動生成された部分)
            //------------------------------------------------------------
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //------------------------------------------------------------
            /// 起動モードに対応する画面を実行する
            //------------------------------------------------------------
            if (AppBase.IsDebuggerMode(args))
            {                                                           //// 起動モード = デバッガーモード の場合
                using (var mutex = new Mutex(false, AppBase.MUTEXNAME_DEBUGGER_RUNNING))
                {                                                       /////  using：デバッガー動作中ミューテックスを生成する
                    Application.Run(new FrmSnowfallDebugger());         //////   雪景色デバッガー画面を実行する
                }
            }
            else
            {                                                           //// 起動モード = デバッガーモード でない場合(通常モードの場合)
                Application.Run(new FrmSnowfallApp());                  /////  雪景色ビューアーメイン画面を実行する
            }
        }

    } // class

} // namespace

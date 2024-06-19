// @(h)FrmSnowfallDebugger.cs ver 0.00 ( '24.06.22 Nov-Lab ) 作成開始
// @(h)FrmSnowfallDebugger.cs ver 0.51 ( '24.06.24 Nov-Lab ) ベータ版完成
// @(h)FrmSnowfallDebugger.cs ver 0.52 ( '24.06.26 Nov-Lab ) 機能追加：モニタリングの一時停止機能を追加した
// @(h)FrmSnowfallDebugger.cs ver 0.52a( '24.06.27 Nov-Lab ) その他  ：コメント整理

// @(s)
// 　【雪景色デバッガー画面】雪景色ビューアーのデバッグ用画面です。

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using NovLab;


namespace Exam_NamedSharedMemory
{
    //====================================================================================================
    /// <summary>
    /// 【雪景色デバッガー画面】雪景色ビューアーのデバッグ用画面です。
    /// 雪景色ビューアーの動作状況をリアルタイムにモニタリングすることができます。
    /// </summary>
    /// <remarks><inheritdoc cref="FrmSnowfallApp"/></remarks>
    //====================================================================================================
    public partial class FrmSnowfallDebugger : Form
    {
        //====================================================================================================
        // 内部フィールド
        //====================================================================================================

        /// <summary>
        /// 【経過フレーム数最終値】モニタリング情報を最後に更新したときの経過フレーム数です。
        /// </summary>
        /// <remarks>
        /// 補足<br/>
        /// ・前回の更新時から内容が変化しているかどうかの判定に使用します。<br/>
        /// </remarks>
        protected int m_lastFrameCount = 0;


        //====================================================================================================
        // フォームイベント
        //====================================================================================================

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【コンストラクター】雪景色デバッガー画面の新しいインスタンスを生成します。
        /// (自動生成された内容のままです。)
        /// </summary>
        //--------------------------------------------------------------------------------
        public FrmSnowfallDebugger()
        {
            InitializeComponent();
        }


        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【更新タイマー_Tick】モニタリングデータを更新します。
        /// </summary>
        //--------------------------------------------------------------------------------
        private void TmrRefresh_Tick(object sender, EventArgs e)
        {
            //------------------------------------------------------------
            /// モニタリングデータを更新する
            //------------------------------------------------------------
            if (MnuMonitoring_Pause.Checked == false)
            {                                                           //// モニタリング-一時停止メニューがチェック状態でない場合
                M_Refresh();                                            /////  モニタリングデータ更新処理を行う
            }
        }


        //====================================================================================================
        // 内部メソッド
        //====================================================================================================

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 【モニタリングデータ更新】共有メモリーから最新のモニタリングデータを取得して画面に表示します。
        /// </summary>
        //--------------------------------------------------------------------------------
        protected void M_Refresh()
        {
            //------------------------------------------------------------
            /// 共有メモリーから最新のモニタリングデータを取得する
            //------------------------------------------------------------
            MonitoringData monitoringData = null;                       //// モニタリングデータ = null に初期化する


            var xmlString = SharedMemory.Read();                        //// 共有メモリーからXML文字列を読み取る
            if (xmlString != null)
            {                                                           //// 読み取り成功の場合
                if (xmlString != string.Empty)
                {                                                       /////  XML文字列が空文字列でない場合(メモリマップトファイルが空っぽでない場合)
                    monitoringData =                                    //////   XML文字列を解析してモニタリングデータを取得する(解析失敗時はnullになる)
                        XmlUtil.ParseXmlString<MonitoringData>(xmlString);
                }
            }


            if (monitoringData == null)
            {                                                           //// モニタリングデータ = null の場合(読み取り失敗か、空っぽだったか、内容が正しくない場合)
                TxtFrameCount.Text =
                    "モニタリングデータを取得できません。";             /////  エラーメッセージ(モニタリングデータ取得失敗)を表示する
                return;                                                 /////  関数終了
            }


            //------------------------------------------------------------
            /// モニタリングデータを画面に表示する
            //------------------------------------------------------------
            if (monitoringData.frameCount == m_lastFrameCount)
            {                                                           //// 経過フレーム数が変化していない場合
                return;                                                 /////  画面を更新せずに関数終了
            }
            m_lastFrameCount = monitoringData.frameCount;               //// 経過フレーム数最終値 = 経過フレーム数 に更新する


            TxtFrameCount.Text = m_lastFrameCount.ToString();           //// 経過フレーム数を画面に表示する

            try
            {                                                           //// try開始
                LvwSnowflakeInfo.BeginUpdate();                         /////  リストビューの更新処理を開始する(描画処理を一時停止する)

                while (LvwSnowflakeInfo.Items.Count < monitoringData.snowflakes.Length)
                {                                                       /////  リストビュー項目が不足している間、繰り返す
                    var newItem = LvwSnowflakeInfo.Items.Add("");       //////   リストビュー項目を追加する
                    newItem.SubItems.Add("");   //X位置
                    newItem.SubItems.Add("");   //Y位置
                    newItem.SubItems.Add("");   //角度
                }

                var itemIndex = 0;                                      /////  リストビュー項目インデックス = 0 に初期化する
                foreach (var snowflake in monitoringData.snowflakes)
                {                                                       /////  雪片アニメーション配列を繰り返す
                    var lvwItem = LvwSnowflakeInfo.Items[itemIndex];    //////   リストビュー項目に最新の情報を反映する
                    lvwItem.SubItems[0].Text = itemIndex.ToString();            // インデックス
                    lvwItem.SubItems[1].Text = snowflake.xPos.ToString("F2");   // X位置
                    lvwItem.SubItems[2].Text = snowflake.yPos.ToString("F2");   // Y位置
                    lvwItem.SubItems[3].Text = snowflake.degree.ToString("F2"); // 角度

                    itemIndex++;                                        //////   リストビュー項目インデックスに１加算する
                }
            }
            finally
            {                                                           //// finally：後始末
                LvwSnowflakeInfo.EndUpdate();                           /////  リストビューの更新処理を終了する(描画処理を再開する)
            }
        }

    } // class

} // namespace

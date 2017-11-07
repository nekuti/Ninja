using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Viveコントローラーにアタッチするクラス
/// Stateパターン機能を内蔵
/// 作成者:小嶋 佑太
/// 最終更新:2017/11/06
/// </summary>
namespace Kojima
{
    public class Hand : MonoBehaviour
    {
        #region メンバ変数
        public WireType wireType = WireType.Normal;         // ワイヤーの種類  

        public WeaponType weaponType = WeaponType.Kunai;    // 武器の種類
        #endregion

        #region メソッド

        /// <summary>
        /// 初期化処理
        /// </summary>
        void Awake()
        {

        }

        /// <summary>
        /// 更新前処理
        /// </summary>
        void Start()
        {

        }

        /// <summary>
        /// 更新処理
        /// </summary>
        void Update()
        {

        }

        #endregion
    }
}
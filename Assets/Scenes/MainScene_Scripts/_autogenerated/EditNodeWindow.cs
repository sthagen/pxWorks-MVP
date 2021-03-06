/////////////////////////////////////////
//     THIS IS AUTOGENERATED CODE      //
//       do not change directly        //
/////////////////////////////////////////
using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using CometUI;

namespace MainScene_UI
{
    partial class EditNodeWindow : BaseView //Autogenerated
    {
        /// <summary>Static instance of the view</summary>
        public static EditNodeWindow Instance { get; private set; }
        // Controls
        #pragma warning disable 0414
        //[Header("Controls (auto capture)")]
        [Header("Custom")]
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btClose = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Text txTitle = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btOk = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btCancel = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.InputField ifNodeName = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.RectTransform pnSockets = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Image pnEditSocket = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btInOut = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.InputField ifName1 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btUp = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btDown = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btDelete = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Image pnEditSocket1 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btInOut1 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.InputField ifName11 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btUp1 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btDown1 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btDelete1 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Image pnEditSocket2 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btInOut2 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.InputField ifName12 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btUp2 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btDown2 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btDelete2 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Image pnEditSocket3 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btInOut3 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.InputField ifName13 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btUp3 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btDown3 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btDelete3 = default;
        [AutoGenerated, SerializeField, HideInInspector] UnityEngine.UI.Button btAddSocket = default;
        #pragma warning restore 0414
        
        public override void AutoSubscribe()
        {
            SubscribeOnChanged(btClose);
            SubscribeOnChanged(txTitle);
            SubscribeOnChanged(btOk);
            SubscribeOnChanged(btCancel);
            SubscribeOnChanged(ifNodeName);
            SubscribeOnChanged(pnSockets);
            SubscribeOnChanged(pnEditSocket);
            SubscribeOnChanged(btInOut);
            SubscribeOnChanged(ifName1);
            SubscribeOnChanged(btUp);
            SubscribeOnChanged(btDown);
            SubscribeOnChanged(btDelete);
            SubscribeOnChanged(pnEditSocket1);
            SubscribeOnChanged(btInOut1);
            SubscribeOnChanged(ifName11);
            SubscribeOnChanged(btUp1);
            SubscribeOnChanged(btDown1);
            SubscribeOnChanged(btDelete1);
            SubscribeOnChanged(pnEditSocket2);
            SubscribeOnChanged(btInOut2);
            SubscribeOnChanged(ifName12);
            SubscribeOnChanged(btUp2);
            SubscribeOnChanged(btDown2);
            SubscribeOnChanged(btDelete2);
            SubscribeOnChanged(pnEditSocket3);
            SubscribeOnChanged(btInOut3);
            SubscribeOnChanged(ifName13);
            SubscribeOnChanged(btUp3);
            SubscribeOnChanged(btDown3);
            SubscribeOnChanged(btDelete3);
            SubscribeOnChanged(btAddSocket);
            Subscribe(btClose, () => this.Close());
            Subscribe(btCancel, () => this.Close());
        }
        ///<summary>Data</summary>
        public uGraph.Node node{ get; private set; }
        public bool create{ get; private set; }
        
        [VisibleInGraph(false)]
        public void Build(uGraph.Node node, bool create)
        {
            this.node = node;
            this.create = create;
            OnBuildSafe(true);
        }
        
        public override BaseView Clone()
        {
            var clone = (EditNodeWindow)base.Clone();
            clone.node = node;
            clone.create = create;
            return clone;
        }
    }
}
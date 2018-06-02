﻿/**************************************************************************
 * 类名：TextFactory.cs
 * 描述：文字图元工厂
 * 作者：CJ
 * 日期：Aug 26,2016
 * 
 * ************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapFrame.Core.Interface;
using MapFrame.Core.Model;
using ESRI.ArcGIS.Controls;

namespace MapFrame.ArcGlobe.Tool
{
    /// <summary>
    /// 手动画线
    /// </summary>
    class DrawLine : IMFTool, IMFDraw
    {
        /// <summary>
        /// 命令完成事件
        /// </summary>
        public event EventHandler<MessageEventArgs> CommondExecutedEvent = null;
        /// <summary>
        /// 地图控件对象
        /// </summary>
        private AxGlobeControl mapControl = null;
        /// <summary>
        /// 地图逻辑接口
        /// </summary>
        private IMapLogic mapLogic = null;
        /// <summary>
        /// 线图元
        /// </summary>
        private IMFElement lineElement = null;
        /// <summary>
        /// 图层
        /// </summary>
        private IMFLayer layer = null;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_mapControl">地图控件对象</param>
        public DrawLine(AxGlobeControl _mapControl) 
        {
            this.mapControl = _mapControl;
        }


        /// <summary>
        /// 图层管理
        /// </summary>
        public IMapLogic MapLogic
        {
            set { this.mapLogic = value; }
        }

        /// <summary>
        /// 获取绘制后的图元
        /// </summary>
        /// <returns></returns>
        public IMFElement GetDrawElement()
        {
            return lineElement;
        }

        /// <summary>
        /// 执行命令
        /// </summary>
        public void RunCommond()
        {
            
        }

        /// <summary>
        /// 终止命令
        /// </summary>
        public void ReleaseCommond()
        {
            
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            ReleaseCommond();
        }
    }
}
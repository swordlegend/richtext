﻿
/********************************************************************
created:    2017-08-03
author:     lixianmin

*********************************************************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Unique.RichText
{
    /// <summary>
    /// 表情图片序列化信息
    /// </summary>
    public class InlineSpriteAsset : ScriptableObject
    {
        public Texture TextureSource;
        public List<SpriteItemAsset> spriteItems;
    }
}
﻿using UnityEngine;
using UnityEngine.UI;

namespace SonicRealms.UI
{
    [RequireComponent(typeof(Text))]
    public class OptionPickerCursor : OptionPickerCursorBase
    {
        [SerializeField]
        private Color _focusColor;

        [SerializeField]
        private Color _unfocusColor;
        
        private Text _text;

        protected void Reset()
        {
            _focusColor = Color.white;
            _unfocusColor = GetComponent<Text>().color;
        }

        protected void Awake()
        {
            _text = GetComponent<Text>();
        }

        protected override void OnShow()
        {
            _text.color = _focusColor;
        }

        protected override void OnHide()
        {
            _text.color = _unfocusColor;
        }
    }
}
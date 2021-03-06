using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wanderer.EmojiText
{
    public class ClickTest : MonoBehaviour
    {

        private InlineText _text;

        void Awake()
        {
            _text = GetComponent<InlineText>();
        }

        void OnEnable()
        {
            _text.OnHrefClick.AddListener(OnHrefClick);
        }

        void OnDisable()
        {
            _text.OnHrefClick.RemoveListener(OnHrefClick);
        }

        private void OnHrefClick(string hrefName, int id)
        {
            Debug.Log("点击了 " + hrefName + "  id:" + id);
            //  Application.OpenURL("www.baidu.com");  
        }
    }

}
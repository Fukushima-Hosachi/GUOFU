using UnityEngine;
using TMPro;

public class type : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI textObj = default;
    private float _feedTime = 0.1f; // 文字送り時間
    private float _t = 0f;
    private int _visibleLen = 0;
    private string _text = "";
    
    //テキストを設定
    public void SetText(string text)
    {
        _text = text;
        _visibleLen = 0;
        _t = 0;
        textObj.text = "";
    }
    
    private void Update()
    {
        if (_visibleLen < _text.Length)
        {
           _t += Time.deltaTime;
           if (_t >= _feedTime)
           {
               _t -= _feedTime;
               _visibleLen++;
               textObj.text = _text.Substring(0, _visibleLen); // 1文字ずつ増やす
           }
        }
    }
}
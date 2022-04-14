using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using uMvvm;
using UnityEngine.UI;

public class TestMvvM : MonoBehaviour
{
    BindingProperty<DateTime> dt = new BindingProperty<DateTime>();
    public Text text;
    private Button addTextButton;
    private void Start() 
    {
        addTextButton = this.transform.GetComponent<Button>();
        dt.ValueChange = TimeChange;
        addTextButton.onClick.AddListener(()=>dt.Value = DateTime.Now);
    }
    private void TimeChange(DateTime _value)
    {
        text.text = _value.ToString();
    }
}

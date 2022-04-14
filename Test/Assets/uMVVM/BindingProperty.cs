using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace uMvvm
{
    public class BindingProperty<T>
    {
        public delegate void OnValueChange(T value);
        public OnValueChange ValueChange;
        private T _value;
        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                if(!Equals(_value,value))
                {
                    _value = value;
                    ValueChange?.Invoke(_value);
                }
            }        
        }
        public override string ToString()
        {
            return Value == null ? "" : _value.ToString(); 
        }
    }
}

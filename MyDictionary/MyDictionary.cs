using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<TKey,TValue>
    {
        TKey[] _keyArray;
        TValue[] _valueArray;

        public MyDictionary()
        {
            _keyArray = new TKey[0];
            _valueArray = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {
            TKey[] _tempKeyArray = _keyArray;
            TValue[] _tempValueArray = _valueArray;

            _keyArray = new TKey[_keyArray.Length+1];
            _valueArray = new TValue[_valueArray.Length+1];

            for (int i = 0; i < _tempKeyArray.Length ; i++)     //key ve value değerleri eşit olduğundan _tempKeyArray.Length veya _tempValueArray.Length kullanılabilir.
            {
                _keyArray[i] = _tempKeyArray[i];
                _valueArray[i] = _tempValueArray[i];
            }

            _keyArray[_keyArray.Length-1] = key;
            _valueArray[_valueArray.Length-1] = value;
        }

        public void Remove(TKey key)
        {
            TKey[] _tempKeyArray = _keyArray;
            TValue[] _tempValueArray = _valueArray;

            _keyArray = new TKey[_keyArray.Length - 1];
            _valueArray = new TValue[_valueArray.Length - 1];

            for (int i = 0; i < _keyArray.Length; i++)
            {
                if (_tempKeyArray[i].ToString() == key.ToString())
                {
                    for (int j = i; j < _keyArray.Length; j++)
                    {
                        _keyArray[j] = _tempKeyArray[j + 1];
                        _valueArray[j] = _tempValueArray[j + 1];
                    }
                    break;
                }

                else
                {
                    _keyArray[i] = _tempKeyArray[i];
                    _valueArray[i] = _tempValueArray[i];
                }
            }
        }

        public int CountKeys
        {
            get { return _keyArray.Length; }
        }
        public int CountValues
        {
            get { return _valueArray.Length; }
        }

        public TKey[] Keys
        {
            get { return _keyArray; }
        }

        public TValue[] Values
        {
            get { return _valueArray; }
        }
    }
}

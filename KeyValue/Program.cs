using System;
using System.Collections.Generic;

namespace KeyValue
{
    struct KeyValue
    {
        public readonly string Key;
        public readonly object Value;

        public KeyValue(string key, object value)
        {
            Key = key;
            Value = value;
        }
    }

    class MyDictionary
    {
        KeyValue[] kvs = new KeyValue[5];
        int storedValues = 0;

              public object GetValueKey(string key)
            {

                for (int i = 0; i < storedValues; i++)
                {
                    if (key == kvs[i].Key)
                    {
                        return kvs[i].Value;
                    }
                } 
                throw new KeyNotFoundException();
            }
        public void AddOrReplaceKeyValue(KeyValue newKeyValue)
        {
            bool foundMatchingKey = false;
            for (int i = 0; i < storedValues; i++)
            {
                if (newKeyValue.Key == kvs[i].Key)
                {
                    foundMatchingKey = true;
                    kvs[i] = newKeyValue;
                }
            }

            if (!foundMatchingKey)
            {
                kvs[storedValues++] = newKeyValue;
            }
        }
        }
}

    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary();

            try
            {
                Console.WriteLine(d["cats"]);
            }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        d["cats"] = 42;
        d["dogs"] = 17;

        Console.WriteLine()
    }
    }
}

using System.Collections.Generic;

//1
KeyValuePair<string, int> meaning = new KeyValuePair<string, int>("Life", 42);

meaning.Print();

//2
Console.WriteLine(Utility.CompateValues(2, 2));
Console.WriteLine(Utility.CompateTypes(2, "not"));

//1
class KeyValuePair<TKey, TValue>
{
    public TKey key;
    public TValue value;

    public KeyValuePair(TKey _key,TValue _value)
    {
        key = _key;
        value = _value;
    }

    public void Print()
    {
        Console.WriteLine($"Key: {key.ToString()}");
        Console.WriteLine($"Value: {value.ToString()}");
    }

    
}
//2
class Utility
{
    public static bool CompateValues<TFirst, TSecond>(TFirst value1, TSecond value2)
    {
        if (value1.Equals(value2)){
            return true;
        }
        return false;
    }
    public static bool CompateTypes<TFirst, TSecond>(TFirst value1, TSecond value2)
    {
        if (typeof(TFirst).Equals(typeof(TSecond)))
        {
            return true;
        }
        return false;
    }
}
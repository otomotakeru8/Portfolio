using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities
{
    public static bool IsAnyTrue(bool one, bool two)
    {
        if (one == true) return true;
        if (two == true) return true;
        return false;
    }
    public static bool IsAnyTrue(bool one, bool two, bool three)
    {
        if (one == true) return true;
        if (two == true) return true;
        if (three == true) return true;
        return false;
    }
    public static bool IsAnyTrue(bool one, bool two, bool three, bool four)
    {
        if (one == true) return true;
        if (two == true) return true;
        if (three == true) return true;
        if (four == true) return true;
        return false;
    }
    public static void AddToReferenceTypesArray<T>(T[] array, T value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (EqualityComparer<T>.Default.Equals(array[i], default(T)))
            {
                array[i] = value;
                return;
            }
        }
    }
    public static void AddToIntArray(ref int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                array[i] = value;
                return;
            }
        }
    }
    public static void RemoveToReferenceTypesArray<T>(T[] array, T value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (EqualityComparer<T>.Default.Equals(array[i], default(T)))
            {
                continue;
            }
            if (array[i].Equals(value))
            {
                array[i] = default(T);
                return;
            }
        }
    }
    public static int ArrayContentsValue<T>(T[] array)
    {
        int resultValue = 0;
        foreach (T item in array)
        {
            if (EqualityComparer<T>.Default.Equals(item, default(T)) == false)
            {
                resultValue++;
            }
        }
        return resultValue;
    }
    public static bool CheckNullData<T>(T arrayData)
    {
        return EqualityComparer<T>.Default.Equals(arrayData, default(T));
    }
}

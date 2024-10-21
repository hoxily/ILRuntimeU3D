using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// dummy JSONObject class.
/// </summary>
public class JSONObject
{
    public bool GetField(out bool field, string name, bool default_value)
    {
        field = default_value;
        return true;
    }

    public bool GetField(out int field, string name, int default_value)
    {
        field = default_value;
        return true;
    }
}

/// <summary>
/// example Data class.
/// </summary>
public class Data
{
    public int _int_value;
    public bool _bool_value;
}


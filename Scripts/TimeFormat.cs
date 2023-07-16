using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Globalization;
using TMPro;

public class TimeFormat : MonoBehaviour
{
    private string input;
    public TMP_Text _formatedTime;

    public string FormattingTime(string input)
    {
        // Format 
        DateTime time;
        CultureInfo provider = CultureInfo.InvariantCulture;
        DateTime.TryParseExact(input, "hh:mm:ss tt", provider, DateTimeStyles.None, out time);
    
        // Mengubah ke format 24 Jam
        DateTimeFormatInfo dtfi = CultureInfo.InvariantCulture.DateTimeFormat;
        string output = time.ToString("HH:mm:ss", dtfi);
        return output;
    }

    public void ReadStringInput(string s)
    {
        input = s;
        _formatedTime.text = FormattingTime(input);
        Debug.Log(FormattingTime(input));
    }
}

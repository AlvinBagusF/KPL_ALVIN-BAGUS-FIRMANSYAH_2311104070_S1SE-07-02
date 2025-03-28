﻿using System;
using System.Collections.Generic;

class KodeBuah
{
    private static Dictionary<string, string> kodeBuahDict = new Dictionary<string, string>
    {
        {"Apel", "A00"},
        {"Aprikot", "B00"},
        {"Alpukat", "C00"},
        {"Pisang", "D00"},
        {"Paprika", "E00"},
        {"Blackberry", "F00"},
        {"Ceri", "H00"},
        {"Kelapa", "I00"},
        {"Jagung", "J00"},
        {"Kurma", "K00"},
        {"Durian", "L00"},
        {"Anggur", "M00"},
        {"Melon", "N00"},
        {"Semangka", "O00"}
    };

    public static string GetKodeBuah(string namaBuah)
    {
        if (kodeBuahDict.ContainsKey(namaBuah))
        {
            return kodeBuahDict[namaBuah];
        }
        else
        {
            return "Kode buah tidak ditemukan!";
        }
    }
}

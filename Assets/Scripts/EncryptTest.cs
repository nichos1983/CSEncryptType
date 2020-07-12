using UnityEngine;
using System;
using CitrusUtils;

public class EncryptTest : MonoBehaviour
{
    public void Start()
    {
        TestInts();
        TestFloats();
        TestOperators();
    }

    public void TestInts()
    {
        Debug.Log("====== TestInts ======");

        EncryptInt e1 = new EncryptInt();
        e1.SetValue(123);
        int i1 = e1.GetValue();
        Debug.Log($"i1 = {i1}");

        i1 += 2;
        e1.SetValue(i1);
        i1 = e1.GetValue();
        Debug.Log($"i1 = {i1}");

        EncryptInt e2 = new EncryptInt();
        e2.SetValue(int.MaxValue);
        int i2 = e2.GetValue();
        Debug.Log("i2 = " + i2.ToString("X"));

        EncryptUInt e3 = new EncryptUInt();
        e3.SetValue(uint.MaxValue);
        uint i3 = e3.GetValue();
        Debug.Log("i3 = " + i3.ToString("X"));

        EncryptLong e4 = new EncryptLong();
        e4.SetValue(long.MaxValue);
        long i4 = e4.GetValue();
        Debug.Log("i4 = " + i4.ToString("X"));

        EncryptULong e5 = new EncryptULong();
        e5.SetValue(ulong.MaxValue);
        ulong i5 = e5.GetValue();
        Debug.Log("i5 = " + i5.ToString("X"));

        EncryptByte e6 = new EncryptByte();
        e6.SetValue(byte.MaxValue);
        byte i6 = e6.GetValue();
        Debug.Log("i6 = " + i6.ToString("X"));

        EncryptSByte e7 = new EncryptSByte();
        e7.SetValue(sbyte.MaxValue);
        sbyte i7 = e7.GetValue();
        Debug.Log("i7 = " + i7.ToString("X"));

        EncryptShort e8 = new EncryptShort();
        e8.SetValue(short.MaxValue);
        short i8 = e8.GetValue();
        Debug.Log("i8 = " + i8.ToString("X"));

        EncryptUShort e9 = new EncryptUShort();
        e9.SetValue(ushort.MaxValue);
        ushort i9 = e9.GetValue();
        Debug.Log("i9 = " + i9.ToString("X"));
    }

    public void TestFloats()
    {
        Debug.Log("====== TestFloats ======");

        EncryptFloat e1 = new EncryptFloat();
        e1.SetValue(1234.0f);
        float f1 = e1.GetValue();
        Debug.Log($"f1 = {f1}");

        e1.SetValue(float.MaxValue);
        f1 = e1.GetValue();
        Debug.Log($"f1 = {f1} and {float.MaxValue}");

        e1.SetValue(float.MinValue);
        f1 = e1.GetValue();
        Debug.Log($"f1 = {f1} and {float.MinValue}");

        e1.SetValue(float.NaN);
        f1 = e1.GetValue();
        Debug.Log($"f1 = {f1} and {float.NaN}");

        EncryptDouble e2 = new EncryptDouble();
        e2.SetValue(1234.0f);
        double f2 = e2.GetValue();
        Debug.Log($"f2 = {f2}");

        e2.SetValue(double.MaxValue);
        f2 = e2.GetValue();
        Debug.Log($"f2 = {f2} and {double.MaxValue}");

        e2.SetValue(double.MinValue);
        f2 = e2.GetValue();
        Debug.Log($"f2 = {f2} and {double.MinValue}");

        e2.SetValue(double.NaN);
        f2 = e2.GetValue();
        Debug.Log($"f2 = {f2} and {double.NaN}");
    }

    void TestOperators()
    {
        Debug.Log("====== TestOperators ======");

        EncryptInt e1 = new EncryptInt();
        e1.SetValue(123);
        int i1 = e1.GetValue();
        Debug.Log($"i1:{i1}, e1:{e1}");

        EncryptInt e2 = new EncryptInt();
        e2.SetValue(123);
        bool b1 = e1 == e2;
        bool b2 = e1 != e2;
        Debug.Log($"b1:{b1}, b2:{b2}");

        EncryptInt e3 = new EncryptInt();
        e3.SetValue(24);
        bool b3 = e1 == e3;
        bool b4 = e1 != e3;
        Debug.Log($"b3:{b3}, b4:{b4}");

        bool b5 = e1 == 123;
        bool b6 = e1 != 123;
        bool b7 = e1 == 1;
        bool b8 = e1 != 1;
        Debug.Log($"b5:{b5}, b6:{b6}, b7:{b7}, b8:{b8},");
        
        bool b9 = 123 == e1;
        bool b10 = 123 != e1;
        bool b11 = 1 == e1;
        bool b12 = 1 != e1;
        Debug.Log($"b9:{b9}, b10:{b10}, b11:{b11}, b12:{b12},");

        EncryptInt e4 = e1++;
        EncryptInt e5 = ++e1;
        EncryptInt e6 = e1--;
        EncryptInt e7 = --e1;
        Debug.Log($"e4:{e4.GetValue()}, e5:{e5.GetValue()}, e6:{e6.GetValue()}, e7:{e7.GetValue()}");
    }
}

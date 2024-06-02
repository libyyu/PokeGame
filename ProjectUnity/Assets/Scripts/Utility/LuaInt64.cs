using SLua;
using System;
using UnityEngine;

[CustomLuaClass]
public static class LuaInt64
{
	public static byte[] Make(Int32 high, Int32 low)
	{
		unchecked
		{
			UInt64 uint64_value = (UInt64)high;
			uint64_value = ((uint64_value << 32) | (UInt32)low);
			return BitConverter.GetBytes(uint64_value);
		}
	}

    public static byte[] FromString(string str)
    {
        Int64 v;
        Int64.TryParse(str, out v);
        return BitConverter.GetBytes(v);
    }

	public static byte[] And(byte[] left, byte[] right)
	{
		long int64_value_l = BitConverter.ToInt64(left, 0);
		long int64_value_r = BitConverter.ToInt64(right, 0);

		return BitConverter.GetBytes(int64_value_l & int64_value_r);
	}

	public static byte[] Or(byte[] left, byte[] right)
	{
		long int64_value_l = BitConverter.ToInt64(left, 0);
		long int64_value_r = BitConverter.ToInt64(right, 0);

		return BitConverter.GetBytes(int64_value_l | int64_value_r);
	}

	public static byte[] Xor(byte[] left, byte[] right)
	{
		long int64_value_l = BitConverter.ToInt64(left, 0);
		long int64_value_r = BitConverter.ToInt64(right, 0);

		return BitConverter.GetBytes(int64_value_l ^ int64_value_r);
	}

	public static byte[] FromDouble(double v)
	{
		return BitConverter.GetBytes((long)v);
	}

	public static double ToDouble(byte[] v)
	{
		return (double)BitConverter.ToInt64(v, 0);
	}

    public static string ToString(byte[] v)
	{
        long int64_value = BitConverter.ToInt64(v, 0);
		return int64_value.ToString();
	}

    public static byte[] Int64ToBytes(Int64 v)
    {
        return BitConverter.GetBytes(v);
    }

    public static Int64 BytesToInt64(byte[] v)
    {
        return BitConverter.ToInt64(v, 0);
    }
}

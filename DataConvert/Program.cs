using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataConvert
{
    class Program
    {
        /// <summary>
        /// Convert from short to Byte
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private byte[] TransShortToByte(short[] value)
        {
            if (value == null)
                return (byte[])null;
            byte[] byteTran = new byte[value.Length * 2];
            for (int index = 0; index < value.Length; index++)
            {
                //Index is position start of array
                BitConverter.GetBytes(value[index]).CopyTo(byteTran, 2 * index);
            }
            return byteTran;
        }
        /// <summary>
        /// Convert from UInt16 to Byte
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private byte[] TransUInt16ToByte(UInt16[] value)
        {
            if (value == null)
                return (byte[])null;
            byte[] byteTran = new byte[value.Length * 2];
            for (int index = 0; index < value.Length; index++)
            {
                //Index is position start of array
                BitConverter.GetBytes(value[index]).CopyTo(byteTran, 2 * index);
            }
            return byteTran;
        }
        /// <summary>
        /// Convert from int to Byte
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private byte[] TransInt32ToByte(int[] value)
        {
            if (value == null)
                return (byte[])null;
            byte[] byteTran = new byte[value.Length * 4];
            for (int index = 0; index < value.Length; index++)
            {
                //Index is position start of array
                BitConverter.GetBytes(value[index]).CopyTo(byteTran, 4 * index);
            }
            return byteTran;
        }
        /// <summary>
        /// Convert from UInt32 to Byte
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private byte[] TransUInt32ToByte(UInt32[] value)
        {
            if (value == null)
                return (byte[])null;
            byte[] byteTran = new byte[value.Length * 4];
            for (int index = 0; index < value.Length; index++)
            {
                //Index is position start of array
                BitConverter.GetBytes(value[index]).CopyTo(byteTran, 4 * index);
            }
            return byteTran;
        }
        /// <summary>
        /// Convert from long to Byte
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private byte[] TransInt64ToByte(long[] value)
        {
            if (value == null)
                return (byte[])null;
            byte[] byteTran = new byte[value.Length * 8];
            for (int index = 0; index < value.Length; index++)
            {
                //Index is position start of array
                BitConverter.GetBytes(value[index]).CopyTo(byteTran, 8 * index);
            }
            return byteTran;
        }
        /// <summary>
        /// Convert from UInt64 to Byte
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private byte[] TransUInt64ToByte(UInt64[] value)
        {
            if (value == null)
                return (byte[])null;
            byte[] byteTran = new byte[value.Length * 8];
            for (int index = 0; index < value.Length; index++)
            {
                //Index is position start of array
                BitConverter.GetBytes(value[index]).CopyTo(byteTran, 8 * index);
            }
            return byteTran;
        }
        /// <summary>
        /// Convert from double to Byte
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private byte[] TransDoubleToByte(Double[] value)
        {
            if (value == null)
                return (byte[])null;
            byte[] byteTran = new byte[value.Length * 8];
            for (int index = 0; index < value.Length; index++)
            {
                //Index is position start of array
                BitConverter.GetBytes(value[index]).CopyTo(byteTran, 8 * index);
            }
            return byteTran;
        }
        /// <summary>
        /// Convert from Float to Byte
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private byte[] TransFloatToByte(float[] value)
        {
            if (value == null) return null;
            byte[] byteArray = new byte[value.Length * 4];
            for (int l = 0; l < value.Length; l++)
            {
                BitConverter.GetBytes(value[l]).CopyTo(byteArray, l * 4);
            }
            return byteArray;
        }
        /// <summary>
        /// Convert from String to Byte
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private byte[] TransStringToByte(string value)
        {
            if (value == null) return null;
            return Encoding.ASCII.GetBytes(value);
        }
        /// <summary>
        /// Convert from Byte to Short
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private short[] TransByteToShort(byte[] value)
        {
            if (value == null) return null;
            if (value.Length % 2 > 0)
                Array.Resize(ref value, value.Length + 1);
            short[] valTran = new short[value.Length / 2];
            for (int i = 0; i < valTran.Length; i++)
            {
                valTran[i] = BitConverter.ToInt16(value, i * 2);

            }
            return valTran;
        }
        /// <summary>
        /// Convert from Byte to Int32
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int[] TransByteToInt32(byte[] value)
        {
            if (value == null) return null;
            int[] int32Array = new int[value.Length / 4];
            for (int j = 0; j < int32Array.Length; j++)
            {
                int32Array[j] = BitConverter.ToInt32(value, j * 4);
            }
            return int32Array;
        }
        /// <summary>
        /// Convert from Byte to Int64
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private long[] TransByteToInt64(byte[] value)
        {
            if (value == null) return null;
            long[] int64Array = new long[value.Length / 8];
            for (int k = 0; k < int64Array.Length; k++)
            {
                int64Array[k] = BitConverter.ToInt64(value, k * 8);
            }
            return int64Array;
        }
        /// <summary>
        /// Convert from Byte to Double
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private double[] TransByteToDouble(byte[] value)
        {
            if (value == null) return null;
            double[] doubleArray = new double[value.Length / 8];
            for (int k = 0; k < doubleArray.Length; k++)
            {
                doubleArray[k] = BitConverter.ToDouble(value, k * 8);
            }
            return doubleArray;
        }
        /// <summary>
        /// Convert from Byte to Float
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private float[] TransByteToFloat(byte[] value)
        {
            if (value == null) return null;
            float[] floatArray = new float[value.Length / 4];
            for (int j = 0; j < floatArray.Length; j++)
            {
                floatArray[j] = BitConverter.ToSingle(value, j * 4);
            }
            return floatArray;
        }
        /// <summary>
        /// Convert from Byte to String
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string TransByteToString(byte[] value)
        {
            return Encoding.UTF8.GetString(value);
        }
        /// <summary>
        /// Convert from Byte to UInt16
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private UInt16[] TransByteToUInt16(byte[] value)
        {
            if (value == null) return null;
            if (value.Length % 2 > 0)
                Array.Resize(ref value, value.Length + 1);
            UInt16[] valTran = new UInt16[value.Length / 2];
            for (int i = 0; i < valTran.Length; i++)
            {
                valTran[i] = BitConverter.ToUInt16(value, i * 2);
            }
            return valTran;
        }
        /// <summary>
        /// Convert from Byte to UInt32
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private UInt32[] TransByteToUInt32(byte[] value)
        {
            if (value == null) return null;
            if (value.Length % 4 > 0)
                Array.Resize(ref value, value.Length + 1);
            UInt32[] valTran = new UInt32[value.Length / 4];
            for (int i = 0; i < valTran.Length; i++)
            {
                valTran[i] = BitConverter.ToUInt32(value, i * 4);
            }
            return valTran;
        }
        /// <summary>
        /// Convert from Byte to UInt64
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private UInt64[] TransByteToUInt64(byte[] value)
        {
            if (value == null) return null;
            if (value.Length % 8 > 0)
                Array.Resize(ref value, value.Length + 1);
            UInt64[] valTran = new UInt64[value.Length / 8];
            for (int i = 0; i < valTran.Length; i++)
            {
                valTran[i] = BitConverter.ToUInt64(value, i * 8);
            }
            return valTran;
        }
        /// <summary>
        /// Convert from Uint16 To Int16
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool TranUint16ToInt16(UInt16[] valve, ref short[] res)
        {
            try
            {
                for (int i = 0; i < valve.Length; i++)
                {
                    res[i] = Convert.ToInt16(valve[i].ToString("X4"), 16);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}

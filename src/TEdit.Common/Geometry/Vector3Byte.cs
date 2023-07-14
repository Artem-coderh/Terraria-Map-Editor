﻿/* 
Copyright (c) 2011 BinaryConstruct
 
This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
 */

using System;

namespace TEdit.Geometry;

[Serializable]
public struct Vector3Byte
{

    public byte X;
    public byte Y;
    public byte Z;

    public Vector3Byte(byte x, byte y, byte z)
        : this()
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override string ToString()
    {
        return $"({X:0},{Y:0},{Z:0})";
    }

    public bool Equals(Vector3Byte other)
    {
        return other.X == X && other.Y == Y && other.Z == Z;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (obj.GetType() != typeof(Vector3Byte)) return false;
        return Equals((Vector3Byte)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int result = X;
            result = result * 397 ^ Y;
            result = result * 397 ^ Z;
            return result;
        }
    }

    public static bool operator ==(Vector3Byte left, Vector3Byte right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Vector3Byte left, Vector3Byte right)
    {
        return !left.Equals(right);
    }
}

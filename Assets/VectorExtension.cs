using UnityEngine;

public static class VectorExtensions 
{
   public static Vector2 xy(this Vector3 v3)
    {
        return new Vector2(v3.x, v3.y);
    }

    public static Vector2 xz(this Vector3 v3)
    {
        return new Vector2(v3.x, v3.z);
    }

    public static Vector2 yz(this Vector3 v3)
    {
        return new Vector2(v3.y, v3.z);
    }

    public static Vector3 x_y(this Vector2 v2, float a = 0)
    {
        return new Vector3(v2.x, a, v2.y);
    }

    public static Vector2 Rotated(this Vector2 v2, float angle)
    {
        float cs = Mathf.Cos(angle);
        float sn = Mathf.Sin(angle);
        float x = v2.x * cs - v2.y * sn;
        float y = v2.x * sn + v2.y * cs;
        v2.x = x;
        v2.y = y;
        return v2;
    }
}
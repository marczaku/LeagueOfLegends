namespace Utility;

public struct Vector3
{
    /// <summary>
    /// The signed length of the vector on the Left to Right Axis.
    /// </summary>
    public float x;
    
    /// <summary>
    /// The signed length of the vector on the Bottom to Top Axis.
    /// <seealso cref="Up"/>
    /// <seealso cref="Down"/>
    /// </summary>
    public float y;
    
    /// <summary>
    /// The signed length of the vector on the Back to Front Axis.
    /// </summary>
    public float z;
    
    /// <summary>
    /// The negative direction on the y-Axis in World Space.
    /// <seealso cref="y"/>
    /// </summary>
    public static Vector3 Down
    {
        get
        {
            return new Vector3(0, 0, -1);
        }
    }
    
    public static Vector3 Up
    {
        get
        {
            // TODO: Add down, left, right, forward and backward
            return new Vector3(0, 0, 1);
        }
    }

    public float Magnitude
    {
        get
        {
            return MathF.Sqrt(this.x * x + y * y + z * z);
        }
    }

    public Vector3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    /// <summary>
    /// Calculates the Dot Product, which is the shadow of the projection of one vector onto another.
    /// </summary>
    public static float Dot(Vector3 a, Vector3 b)
    {
        return a.x * b.x + a.y * b.y + a.z * b.z;
    }
}
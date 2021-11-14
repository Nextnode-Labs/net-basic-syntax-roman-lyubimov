/// <summary>The main class.</summary>
class Chapter_3
{
    /** <summary>Program entry point.</summary>
        <param name="args">Command line arguments.</param>
    */
    static void Main(string[] args)
    {
        int myInt = 10, myInt2 = 20, myInt3;
        System.Console.Write(myInt); // "10"

        // Signed integers
        sbyte myInt8  = 2; // -128   to +127
        short myInt16 = 1; // -32768 to +32767
        int   myInt32 = 0; // -2^31  to +2^31-1
        long  myInt64 =-1; // -2^63  to +2^63-1

        byte   uInt8  = 0;  // 0 to 255
        ushort uInt16 = 1;  // 0 to 65535
        uint   uInt32 = 2;  // 0 to 2^32-1
        ulong  uInt64 = 3;  // 0 to 2^64-1

        int myHex = 0xF;    // 15 in hexadecimal (base 16)
        int myBin = 0b0100; // 4 in binary (base 2)

        float   myFloat   = 3.14F; // 7 digits of precision
        double  myDouble  = 3.14;  // 15-16 digits of precision
        decimal myDecimal = 3.14M; // 28-29 digits of precision

        char c = 'a'; // Unicode char

        bool b = true; // bool value
    }
}

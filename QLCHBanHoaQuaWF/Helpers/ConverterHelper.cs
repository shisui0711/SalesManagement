namespace QLCHWF.Helpers;

public static class ConverterHelper
{
    public static byte[] BitmapToBytes(Bitmap bitmap)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            bitmap.Save(ms,bitmap.RawFormat);
            return ms.ToArray();
        }
    }
}
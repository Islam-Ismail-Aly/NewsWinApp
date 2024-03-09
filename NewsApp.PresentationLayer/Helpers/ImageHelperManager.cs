using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.PresentationLayer.Helpers
{
    public static class ImageHelperManager
    {
        internal static byte[] ImageToByteArray(Image image)
        {
            if (image is null)
                return null;

            using (var memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }

        internal static Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray.Length is 0)
                return null;
                

            using (var memoryStream = new MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Client
{
    class ImageHelper
    {
        public Image GenerateThumbnailImage(string imgUrl)
        {
            Image imgThumb = null;
            try
            {
                Image image = null;
                if (imgUrl != String.Empty)
                    image = Image.FromFile(imgUrl);

                if (image != null)
                {
                    imgThumb = image.GetThumbnailImage(130, 170, null, new IntPtr());
                    //this.Refresh();
                }
                return imgThumb;
            }
            catch
            {
                return imgThumb;
            }
        }

        public byte[] ImageToByte(Image imageIn)
        {

            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }


    }
}

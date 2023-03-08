using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal static class ConvFilterPrep
    {

        public static Bitmap ConvolutionFilter(Bitmap sourceBitmap, ConvFilterBase filter)
        {
            double b = 0.0;
            double g = 0.0;
            double r = 0.0;

            Bitmap finalBitmap = (Bitmap)sourceBitmap.Clone();
            int imgWidth = sourceBitmap.Width;
            int imgHeight = sourceBitmap.Height;

            int filterWidth = filter.FilterMatrix.GetLength(0);
            int filterHeight = filter.FilterMatrix.GetLength(1);

            int anchorX = filter.GetanchorX;
            int anchorY = filter.GetanchorY;

            int offsetX1;
            int offsetY1;
            int offsetX2;
            int offsetY2;

            if (anchorX >= 0 || anchorY >= 0)
            {
                offsetX1 = anchorX;
                offsetX2 = filterWidth - 1 - anchorX;
                offsetY1 = anchorY;
                offsetY2 = filterHeight - 1 - anchorY;
                
            }
            else
            {
                offsetX1 = (filterWidth - 1) / 2;
                offsetX2 = offsetX1;
                offsetY1 = (filterHeight - 1) / 2;
                offsetY2 = offsetY1;
            }
            

            for (int y = offsetY1; y <= imgHeight - 1 - offsetY2; y++)
            {
                for (int x = offsetX1; x <= imgWidth - 1 - offsetX2; x++)
                {
                    b = 0.0;
                    g = 0.0;
                    r = 0.0;

                    for (int filterY = -offsetY1; filterY <= offsetY2; filterY++)
                    {
                        for (int filterX = -offsetX1; filterX <= offsetX2; filterX++)
                        {
                            Color px = sourceBitmap.GetPixel(x + filterX, y + filterY);

                            r += (double)filter.FilterMatrix[filterX + offsetX1, filterY + offsetY1] * px.R;


                            g += (double)filter.FilterMatrix[filterX + offsetX1, filterY + offsetY1] * px.G;


                            b += (double)filter.FilterMatrix[filterX + offsetX1, filterY + offsetY1] * px.B;
                        }
                    }

                    int[] newRGB = {(int)(r / filter.Factor + filter.Bias),
                        (int)(g / filter.Factor + filter.Bias), (int)(b / filter.Factor + filter.Bias)};
                    for (int i = 0; i < newRGB.Length; i++)
                    {
                        if (newRGB[i] > 255)
                        {
                            newRGB[i] = 255;
                        }
                        if (newRGB[i] < 0)
                        {
                            newRGB[i] = 0;
                        }
                    }

                    Color finalColor = Color.FromArgb(255, newRGB[0], newRGB[1], newRGB[2]);
                    finalBitmap.SetPixel(x, y, finalColor);
                }
            }
            return finalBitmap;
        }
        //public static Bitmap ConvolutionFilter(ConvFilterBase filter, PictureBox pictureBoxAfter)
        //{
        //    int filterWidth = filter.FilterMatrix.GetLength(1);
        //    int filterOffset = (filterWidth - 1) / 2;

        //    Bitmap img = new Bitmap(pictureBoxAfter.Image);
        //    int imgWidth = img.Width;
        //    int imgHeight = img.Height;

        //    for (int x = 0; x < imgWidth; x++)
        //    {
        //        for (int y = 0; y < imgHeight; y++)
        //        {
        //            double r = 0;
        //            double g = 0;
        //            double b = 0;
        //            for (int fx = 0; fx < filterWidth; fx++)
        //            {
        //                int fitx = (fx + x - filterOffset <= 0) ? 0 :
        //                    (fx + x - filterOffset >= imgWidth - 1) ? imgWidth - 1 : fx + x - filterOffset;
        //                for (int fy = 0; fy < filterWidth; fy++)
        //                {
        //                    int fity = (fy + y - filterOffset <= 0) ? 0 :
        //                    (fy + y - filterOffset >= imgHeight - 1) ? imgHeight - 1 : fy + y - filterOffset;
        //                    Color pixelColor = img.GetPixel(fitx, fity);
        //                    r += (pixelColor.R * filter.FilterMatrix[fx, fy]);
        //                    g += (pixelColor.G * filter.FilterMatrix[fx, fy]);
        //                    b += (pixelColor.B * filter.FilterMatrix[fx, fy]);
        //                }
        //            }
        //            int[] newRGB = {(int)(r / filter.Factor + filter.Bias),
        //                (int)(g / filter.Factor + filter.Bias), (int)(b / filter.Factor + filter.Bias)};
        //            for (int i = 0; i < newRGB.Length; i++)
        //            {
        //                if (newRGB[i] > 255)
        //                {
        //                    newRGB[i] = 255;
        //                }
        //                if (newRGB[i] < 0)
        //                {
        //                    newRGB[i] = 0;
        //                }
        //            }
        //            Color final = Color.FromArgb(newRGB[0], newRGB[1], newRGB[2]);
        //            img.SetPixel(x, y, final);
        //        }

        //    }
        //    return img;
        //}
    }
}


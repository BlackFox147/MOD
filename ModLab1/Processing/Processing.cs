//using System.Drawing.Drawing2D;
//using System.Drawing.Imaging;

namespace Processing
{
    public class Processing
    {
        //public IList<ChannelHistogram> CalculateHistogram(Bitmap image)
        //{
        //    var rHistogram = new ChannelHistogram(TypeOfСhannel.RedСhannel);
        //    var gHistogram = new ChannelHistogram(TypeOfСhannel.GreenСhannel);
        //    var bHistogram = new ChannelHistogram(TypeOfСhannel.BlueСhannel);

        //    var resultedHistogram = new List<ChannelHistogram>();

        //    for (int x = 0; x < image.Width; ++x)
        //    {
        //        for (int y = 0; y < image.Height; ++y)
        //        {
        //            AddBrights(rHistogram, gHistogram, bHistogram, image.GetPixel(x, y));
        //        }
        //    }

        //    resultedHistogram.Add(rHistogram);
        //    resultedHistogram.Add(gHistogram);
        //    resultedHistogram.Add(bHistogram);

        //    return resultedHistogram;
        //}

        //private void AddBrights(ChannelHistogram rHistogram, ChannelHistogram gHistogram, ChannelHistogram bHistogram,
        //    Color pixel)
        //{
        //    AddBrightForChannel(pixel.R, rHistogram);
        //    AddBrightForChannel(pixel.G, gHistogram);
        //    AddBrightForChannel(pixel.B, bHistogram);
        //}

        //private void AddBrightForChannel(byte bright, ChannelHistogram channelHistogram)
        //{
        //    if (!channelHistogram.Histogram.ContainsKey(bright))
        //    {
        //        channelHistogram.Histogram.Add(bright, 0);
        //    }
        //    channelHistogram.Histogram[bright]++;
        //}
    }
}

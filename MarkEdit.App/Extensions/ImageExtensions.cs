using System.Drawing.Drawing2D;

namespace MarkEdit.App.Extensions;

public static class ImageExtensions
{
    public static Image ResizeImage(this Image image, Size size, int padding = 0)
    {
        var resized = new Bitmap(size.Width, size.Height);
        using var graphics = Graphics.FromImage(resized);
        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
        graphics.DrawImage(image, padding, padding, size.Width - padding * 2, size.Height - padding * 2);
        return resized;
    }
}
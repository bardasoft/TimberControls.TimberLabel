using Android.App;

namespace TimberControls.Droid.Helpers
{
    public static class ConversionHelpers
    {
        public static int ConvertDPToPixels( int dp )
        {
            float scale = Application.Context.Resources.DisplayMetrics.Density;

            return (int)(dp * scale + 0.5);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfMaps_DifferentView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();           
        }

        /// <summary>
        /// This event is used to pass the uri of desired maps tile provider
        /// </summary>
        /// <param name="sender">The imagery layer</param>
        /// <param name="e">The Tile uri arguments</param>
        private void ImageryLayer_RequestTileUri(object sender, Syncfusion.SfMaps.XForms.TileUriArgs e)
        {
            var link = "http://mt1.google.com/vt/lyrs=m&x=" + e.X.ToString() + "&y=" + e.Y.ToString() + "&z=" + e.ZoomLevel.ToString();
            e.Uri = link;
        }
    }
}

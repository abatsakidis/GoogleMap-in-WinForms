using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Add a reference to System.Web.
using System.Web;
using Microsoft.Win32;

namespace howto_address_integrated_map
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // Make the WebBrowser emulate Internet Explorer 11.
        // Select a default map type.
        private void Form1_Load(object sender, EventArgs e)
        {
            SetWebBrowserVersion(11001);
            cboGoogle.SelectedIndex = 0;
        }

        // Display a Google map.
        private void btnGoogle_Click(object sender, EventArgs e)
        {
            // Get the Google maps URL with defult zoom.
            string url = GoogleMapUrl(txtAddress.Text, cboGoogle.Text, 0);

            // Display the URL in the WebBrowser control.
            wbrMap.Navigate(url);
        }

        // Return a Google map URL.
        // The URL format is:
        //      http://maps.google.com/maps?q=QUERY&t=TYPE&z=ZOOM
        //  Where:
        //      QUERY is the query. If it begins with "loc:" then its latitude+longitude.
        //      TYPE is map type:
        //          m = Map
        //          k = Satellite
        //          h = Hybrid
        //          p = Terrain
        //          e = Google Earth
        //      ZOOM is the zoom level, usually 1 - 20.
        private string GoogleMapUrl(string query, string map_type, int zoom)
        {
            // Start with the base map URL.
            string url = "http://maps.google.com/maps?";

            // Add the query.
            url += "q=" + HttpUtility.UrlEncode(query, Encoding.UTF8);

            // Add the type.
            map_type = GoogleMapTypeCode(map_type);
            if (map_type != null) url += "&t=" + map_type;

            // Add the zoom level.
            if (zoom > 0) url += "&z=" + zoom.ToString();

            return url;
        }

        // Return a Google map type code.
        private string GoogleMapTypeCode(string map_type)
        {
            // Insert the proper type.
            switch (map_type)
            {
                case "Map":
                    return "m";
                case "Satellite":
                    return "k";
                case "Hybrid":
                    return "h";
                case "Terrain":
                    return "p";
                case "Google Earth":
                    return "e";
                default:
                    return null;
            }
        }

        // Make the WebBrowser control emulate the indicated IE version.
        // See:
        //      https://msdn.microsoft.com/library/ee330730.aspx#browser_emulation
        private void SetWebBrowserVersion(int ie_version)
        {
            // For testing:
            //DeleteRegistryValue(key64bit, app_name);
            //DeleteRegistryValue(key32bit, app_name);

            const string key64bit =
                @"SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION";
            const string key32bit =
                @"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION";
            string app_name = System.AppDomain.CurrentDomain.FriendlyName;

            // You can do both if you like.
            //SetRegistryDword(key64bit, app_name, ie_version);
            SetRegistryDword(key32bit, app_name, ie_version);
        }

        // Set a registry DWORD value.
        private void SetRegistryDword(string key_name, string value_name, int value)
        {
            // Open the key.
            RegistryKey key =
                Registry.CurrentUser.OpenSubKey(key_name, true);
            if (key == null)
                key = Registry.CurrentUser.CreateSubKey(key_name,
                    RegistryKeyPermissionCheck.ReadWriteSubTree);

            // Set the desired value.
            key.SetValue(value_name, value, RegistryValueKind.DWord);

            key.Close();
        }

        // Delete a registry value.
        private void DeleteRegistryValue(string key_name, string value_name)
        {
            // Open the key.
            RegistryKey key =
                Registry.CurrentUser.OpenSubKey(key_name, true);
            if (key == null) return;

            // Delete the desired value.
            key.DeleteValue(value_name, false);

            key.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

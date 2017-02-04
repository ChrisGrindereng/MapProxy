using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace StaticMaps
{
    

public class Size
{
    public int width { get; set; }
    public int height { get; set; }
}

public class Location
{
    public double lat { get; set; }
    public double lng { get; set; }
}

public class Marker
{
    public string color { get; set; }
    public string label { get; set; }
    public Location location { get; set; }
}

public class GoogleStaticMaps
{
    public string imageUrl { get; set; }
    public string timestamp { get; set; } = DateTime.Now.ToString();
    public string searchTerm { get; set; }
    public int zoomLevel { get; set; }
    public Size size { get; set; }
    public List<Marker> markers { get; set; }

    public GoogleStaticMaps(string searchTerm, int zoomLevel){
    
        this.searchTerm = searchTerm;
        this.zoomLevel = zoomLevel;
    }
}
}
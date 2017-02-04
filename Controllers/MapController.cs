using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using StaticMaps;

[Route("/api/map")]
public class MapController : Controller {
    private IGoogleRepo googleApi;
    public MapController(IGoogleRepo g){
        googleApi = g;
    }

    [HttpGet("{search}")]
    // http://localhost:5000/api/map/Woodbar?size=800x600
    public async Task<IActionResult> Get(string search, string size="800x600", string zoom="13"){
        // 1. make request to Google
        var key = "AIzaSyCixfkHHa7NI0Pi4_SHrL8wZS3VZiGek9s";
        GoogleGeoCodeRoot geoCode = await googleApi.GetData<GoogleGeoCodeRoot>($"https://maps.googleapis.com/maps/api/geocode/json?address={search}&key={key}");
        // 2. deserialize request from Google   check
        GoogleStaticMaps map = new GoogleStaticMaps(search, Int32.Parse(zoom));
        double lat = geoCode.results.ElementAt(0).geometry.location.lat;
        double lng = geoCode.results.ElementAt(0).geometry.location.lng;
        string latlng = $"{lat.ToString()},{lng.ToString()}";
        map.markers[2].location.lat = lat;
        map.markers[2].location.lng = lng;
        
        API.ToJSON(geoCode);
        //string json = JsonConvert.SerializeObject(map);
        
        map.imageUrl = $"https://maps.googleapis.com/maps/api/staticmap?zoom={zoom}&size={size}&maptype=roadmap&markers=color:red|label:X|{latlng}";
        
        // 3. return new structure back as Object
        return Ok(new {map});
        // string result = await client.GetStringAsync()
        // JSON...
    }   
}

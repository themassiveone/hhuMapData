using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;

[Route("api/fetch")]
public class FetchController : ControllerBase
{

    private MapDataContext context;
    public FetchController(MapDataContext context)
    {
        this.context = context;
    }
    const string hhuMapMarkersUrl = "https://cx.phil.hhu.de/data/markers/xml/markers.xml";
    private HttpClient client = new HttpClient();

    [HttpPost]
    public async Task<ActionResult> Update()
    {
        var httpResponse = await client.GetAsync(hhuMapMarkersUrl);

        var content = httpResponse.Content.ReadAsStream();



        // var markers = JsonConvert.DeserializeXmlNode(content);

        XmlSerializer serializer = new XmlSerializer(typeof(markers));
        markers markers = (markers)serializer.Deserialize(content);

        List<Marker> goodMarkers = new List<Marker>();
        foreach (var marker in markers.Items)
        {
            if (marker is markersMarker markersMarker)
            {
                Marker goodMarker = new Marker();
                // duplicate ids
                // goodMarker.id = markersMarker.id;
                goodMarker.id = Guid.NewGuid().ToString();
                var items = markersMarker.Items;
                var itemsKinds = markersMarker.ItemsElementName;
                for (int i = 0; i < items.Length; i++)
                {
                    var itemKind = itemsKinds[i];
                    var item = items[i];

                    if (itemKind is ItemsChoiceType.lat)
                        goodMarker.lat = item.ToString();
                    if (itemKind is ItemsChoiceType.summary)
                        goodMarker.summary = item.ToString();
                    if (itemKind is ItemsChoiceType.lng)
                        goodMarker.lng = item.ToString();
                    if (itemKind is ItemsChoiceType.title)
                        goodMarker.title = item.ToString();
                }
                goodMarkers.Add(goodMarker);
            }
            Console.WriteLine("marker wasnt castable");
        }

        context.Markers.AddRange(goodMarkers);
        context.SaveChanges();

        //save in database. 
        //this is not intended usage:
        return Ok("Changed " + goodMarkers.Count());


    }
}
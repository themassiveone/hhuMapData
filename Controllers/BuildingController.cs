using Microsoft.AspNetCore.Mvc;

[Route("api/building")]
public class BuildingController : ControllerBase
{
    private MapDataContext context;
    public BuildingController(MapDataContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public ActionResult GetBuildingByName(string name)
    {
        var results = context.Markers.Where(x => x.title.Contains(name)).ToList();

        return Ok(results);
    }
}
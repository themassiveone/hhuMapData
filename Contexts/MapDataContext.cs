using Microsoft.EntityFrameworkCore;

public class MapDataContext : DbContext
{
    private AppSettingsExtractor extractor;
    public MapDataContext(AppSettingsExtractor extractor)
    {
        this.extractor = extractor;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);


        optionsBuilder.UseNpgsql(extractor.AppSettings.ConnectionStrings.MapStorage);
    }

    public DbSet<Marker> Markers { get; set; }
}
using DotGod.Spatial.Graphical.Concave.Geometry.Polygon;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface;

public abstract class SurfaceEnvelope : ISurface
{
	protected SurfaceEnvelope(ISurface surface)
	{
		this.surface = surface;
	}

	public IEnumerable<IPolygon> Polygons => surface.Polygons;

	public Any<Material> Material => surface.Material;

	private readonly ISurface surface;
}
using DotGod.Geometry.Spatial.Graphical.Polygon;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Surface;

public abstract class SurfaceEnvelope : ISurface
{
	protected SurfaceEnvelope(ISurface surface)
	{
		this.surface = surface;
	}

	public IEnumerable<IPolygon> Polygons => surface.Polygons;

	public IScalar<Material> Material => surface.Material;

	private readonly ISurface surface;
}
using DotGod.Geometry.Spatial.Graphical.Polygons;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Surfaces;

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
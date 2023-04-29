using DotGod.Geometrics.Graphical.Polygons;
using Godot;
using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Surfaces;

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
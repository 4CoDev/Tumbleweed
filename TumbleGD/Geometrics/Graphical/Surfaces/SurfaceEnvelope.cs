using Godot;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces;

public abstract class SurfaceEnvelope : ISurface
{
	protected SurfaceEnvelope(ISurface surface)
	{
		this.surface = surface;
	}

	public IEnumerable<IEnumerable<IVertex>> Polygons => surface.Polygons;

	public IScalar<Material> Material => surface.Material;

	private readonly ISurface surface;
}
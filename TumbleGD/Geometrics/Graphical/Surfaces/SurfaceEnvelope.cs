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

	public IEnumerable<IEnumerable<IVertex>> Polygons
	{
		get => surface.Polygons;
	}

	public IScalar<Material> Material
	{
		get => surface.Material;
	}
	
	private readonly ISurface surface;
}
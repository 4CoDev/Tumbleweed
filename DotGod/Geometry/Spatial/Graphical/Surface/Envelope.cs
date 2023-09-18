using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Graphical.Surface;

public abstract class Envelope : Any
{
	protected Envelope(Any surface)
	{
		this.surface = surface;
	}

	public IEnumerable<Graphical.Polygon.Any> Polygons => surface.Polygons;

	public Any<Godot.Material> Material => surface.Material;

	private readonly Any surface;
}
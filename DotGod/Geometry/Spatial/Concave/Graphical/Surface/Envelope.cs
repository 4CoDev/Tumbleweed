using DotGod.Geometry.Spatial.Concave.Graphical.Polygon;
using Godot;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Surface;

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
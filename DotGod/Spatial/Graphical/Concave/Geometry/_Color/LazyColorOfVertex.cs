using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Color;

public sealed class LazyColorOfVertex : Envelope<Color>
{
	public LazyColorOfVertex(IVertex vertex) : base
	(
		new Tumbleweed.Scalar.Immutable.Lazy<Color>(
			new ColorOfVertex(vertex))
	)
	{
	}
}
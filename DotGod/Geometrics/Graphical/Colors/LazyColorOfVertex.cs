using DotGod.Geometrics.Graphical.Vertices;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Colors;

public sealed class LazyColorOfVertex : ScalarEnvelope<Color>
{
	public LazyColorOfVertex(IVertex vertex) : base
	(
		new LazyValue<Color>(
			new ColorOfVertex(vertex))
	)
	{
	}
}
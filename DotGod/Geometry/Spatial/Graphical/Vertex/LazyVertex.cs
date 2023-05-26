using DotGod.Geometry.Spatial.Graphical._Color;
using DotGod.Geometry.Spatial.Graphical.Normal;
using DotGod.Geometry.Spatial.Graphical.Translation;
using DotGod.Geometry.Spatial.Graphical.UV;

namespace DotGod.Geometry.Spatial.Graphical.Vertex;

public sealed class LazyVertex : VertexEnvelope
{
	public LazyVertex(IVertex vertex) : base
	(
		new VertexWithValues(
			new LazyTranslationOfVertex(vertex),
			new LazyNormalOfVertex(vertex),
			new LazyColorOfVertex(vertex),
			new LazyUVOfVertex(vertex))
	)
	{
	}
}
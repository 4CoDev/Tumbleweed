using DotGod.Spatial.Graphical.Concave.Geometry._Color;
using DotGod.Spatial.Graphical.Concave.Geometry.Normal;
using DotGod.Spatial.Graphical.Concave.Geometry.Translation;
using DotGod.Spatial.Graphical.Concave.Geometry.UV;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex;

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
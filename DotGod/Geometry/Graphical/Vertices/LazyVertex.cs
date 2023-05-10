using DotGod.Geometry.Graphical.Colors;
using DotGod.Geometry.Graphical.Normals;
using DotGod.Geometry.Graphical.Translations;
using DotGod.Geometry.Graphical.UVs;

namespace DotGod.Geometry.Graphical.Vertices;

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
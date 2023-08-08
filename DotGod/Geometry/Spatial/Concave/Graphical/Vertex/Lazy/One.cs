using DotGod.Geometry.Spatial.Concave.Graphical.Vertex.Color;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Vertex.Lazy;

public sealed class One : Envelope
{
	public One(Any vertex) : base
	(
		new With.Members(
			new Translation.Lazy(vertex),
			new Normal.Lazy(vertex),
			new Color.Lazy(vertex),
			new UV.Lazy(vertex))
	)
	{
	}
}
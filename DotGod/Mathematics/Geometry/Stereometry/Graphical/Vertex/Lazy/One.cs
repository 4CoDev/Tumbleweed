namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex.Lazy;

public sealed class One : Envelope
{
	public One(Any vertex) : base
	(
		new DotGod.Geometry.Stereometry.Concave.Graphical.Vertex.With.Members(
			new Translation.Lazy(vertex),
			new Normal.Lazy(vertex),
			new Color.Lazy(vertex),
			new UV.Lazy(vertex))
	)
	{
	}
}
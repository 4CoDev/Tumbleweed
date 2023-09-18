using DotGod.Geometry.Spatial.Concave.Graphical.Vertex.With;
using Godot;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Graphical.Vertex.Transformed;

public sealed class One : Envelope
{
	public One
	(
		Any vertex,
		Any<Transform3D> transform
	) : base
	(
		new Members(
			new Point.Spatial.Transformed.One(vertex.Translation, transform),
			vertex.Normal,
			vertex.Color,
			vertex.UV)
	)
	{
	}
}

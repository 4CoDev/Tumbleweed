using DotGod.Geometry.Stereometry.Concave.Graphical.Vertex.With;
using Godot;
using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex.Transformed;

public sealed class One : Envelope
{
	public One
	(
		Any vertex,
		Any<Transform3D> transform
	) : base
	(
		new Members(
			new Vector.Spatial.Tumbleweed.Transformed.One(vertex.Translation, transform),
			vertex.Normal,
			vertex.Color,
			vertex.UV)
	)
	{
	}
}

using DotGod.Spatial.Point;
using Godot;
using Tumbleweed.Geometry.Spatial.Vertex;
using Tumbleweed.Geometry.Spatial.Vertex.Translation;
using Tumbleweed.Geometry.Spatial.Vertex.With;
using Tumbleweed.Geometry.Spatial.Vertex.With.Translation;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using One = Tumbleweed.Geometry.Spatial.Vertex.With.Translation.One;

namespace DotGod.Spatial.Convex.Geometry.Vertex;

public sealed class TransformedVertex : Envelope
{
	public TransformedVertex
	(
		Any vertex,
		Any<Transform3D> transform
	) : base
	(
		new One(
			new TransformedPoint(
				new Tumbleweed.Geometry.Spatial.Vertex.Translation.One(vertex),
				transform))
	)
	{
	}
}
using Tumbleweed.Geometry.Stereometry.Vertex;
using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Vector = DotGod.Vector.Spatial;

namespace DotGod.Geometry.Stereometry.Basic.Vertex.Member.Translation.Vector;

public sealed class One : Scalar::Envelope<Godot::Vector3>
{
	public One(Any vertex) : base
	(
		new Vector::From.Point.One(
			new Tumbleweed.Geometry.Stereometry.Vertex.Member.Translation.One(vertex))
	)
	{
	}
}
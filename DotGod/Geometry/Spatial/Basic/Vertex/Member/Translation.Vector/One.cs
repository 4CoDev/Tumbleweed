using Scalar = Tumbleweed.Scalar.Immutable;
using Godot = Godot;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;
using Vector = DotGod.Vector.Spatial;

namespace DotGod.Geometry.Spatial.Basic.Vertex.Member.Translation.Vector;

public sealed class One : Scalar::Envelope<Godot::Vector3>
{
	public One(Vertex::Any vertex) : base
	(
		new Vector::From.Point.One(
			new Vertex::Member.Translation.One(vertex))
	)
	{
	}
}
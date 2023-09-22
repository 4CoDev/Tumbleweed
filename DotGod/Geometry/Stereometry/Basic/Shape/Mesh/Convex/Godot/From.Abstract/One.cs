using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Geometry.Stereometry.Basic.Shape.Mesh.Convex.Godot.From.Abstract;

public sealed class One : Envelope<ConvexPolygonShape3D>
{
	public One(Shape3D @abstract) : this
	(
		new Value<Shape3D>(@abstract)
	)
	{
	}
	
	public One
	(
		Any<Shape3D> @abstract
	) : base
	(
		new global::Tumbleweed.Object.Casted.Convertee.Object<ConvexPolygonShape3D>(@abstract)
	)
	{
	}
}
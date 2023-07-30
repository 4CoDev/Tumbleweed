using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod._Godot.Spatial.Convex.Geometry.Mesh;

public sealed class MeshFromAbstract : Envelope<ConvexPolygonShape3D>
{
	public MeshFromAbstract(Shape3D @abstract) : this
	(
		new Value<Shape3D>(@abstract)
	)
	{
	}
	
	public MeshFromAbstract
	(
		Any<Shape3D> @abstract
	) : base
	(
		new Tumbleweed.Object.Unpacked<ConvexPolygonShape3D>(@abstract)
	)
	{
	}
}
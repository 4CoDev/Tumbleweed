using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Godot.Spatial.Convex.Geometry.Mesh;

public sealed class MeshFromAbstract : Envelope<ConvexPolygonShape3D>
{
	public MeshFromAbstract(Shape3D @abstract) : this
	(
		new Tumbleweed.Scalar.Of.Value<Shape3D>(@abstract)
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
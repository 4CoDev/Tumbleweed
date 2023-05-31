using Godot;
using Tumbleweed.Scalar;

namespace DotGod._Godot.Spatial.Convex.Geometry.Mesh;

public sealed class MeshFromAbstract : ScalarEnvelope<ConvexPolygonShape3D>
{
	public MeshFromAbstract(Shape3D @abstract) : this
	(
		new ScalarValue<Shape3D>(@abstract)
	)
	{
	}
	
	public MeshFromAbstract
	(
		IScalar<Shape3D> @abstract
	) : base
	(
		new ObjectAsType<ConvexPolygonShape3D>(@abstract)
	)
	{
	}
}
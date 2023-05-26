using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical._Mesh.PrimitiveType;

public sealed class TrianglesType : ScalarEnvelope<Godot.Mesh.PrimitiveType>
{
	public TrianglesType() : base
	(
		new ScalarValue<Godot.Mesh.PrimitiveType>(
			Godot.Mesh.PrimitiveType.Triangles)
	)
	{
	}
}
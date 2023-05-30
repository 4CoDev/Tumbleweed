using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh.PrimitiveType;

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
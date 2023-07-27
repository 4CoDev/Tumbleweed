using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh.PrimitiveType;

public sealed class TrianglesType : Envelope<Godot.Mesh.PrimitiveType>
{
	public TrianglesType() : base
	(
		new Tumbleweed.Scalar.Of.Value<Godot.Mesh.PrimitiveType>(
			Godot.Mesh.PrimitiveType.Triangles)
	)
	{
	}
}
using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes.PrimitiveTypes;

public sealed class TrianglesType : ScalarEnvelope<Mesh.PrimitiveType>
{
	public TrianglesType() : base
	(
		new ScalarValue<Mesh.PrimitiveType>(
			Mesh.PrimitiveType.Triangles)
	)
	{
	}
}
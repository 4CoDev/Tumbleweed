using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.PrimitiveTypes;

public sealed class TrianglesType : ScalarEnvelope<Mesh.PrimitiveType>
{
	public TrianglesType() : base
	(
		new ScalarOfValue<Mesh.PrimitiveType>(
			Mesh.PrimitiveType.Triangles)
	)
	{
	}
}
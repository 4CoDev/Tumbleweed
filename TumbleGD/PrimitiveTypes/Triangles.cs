using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.PrimitiveTypes;

public sealed class Triangles : ScalarEnvelope<Mesh.PrimitiveType>
{
	public Triangles() : base
	(
		new ScalarOfValue<Mesh.PrimitiveType>(Mesh.PrimitiveType.Triangles)
	)
	{
	}
}
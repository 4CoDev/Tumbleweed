using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Geometry.Spatial.Graphical.Mesh.PrimitiveType;

public sealed class Triangles : Envelope<Godot.Mesh.PrimitiveType>
{
	public Triangles() : base
	(
		new Value<Godot.Mesh.PrimitiveType>(
			Godot.Mesh.PrimitiveType.Triangles)
	)
	{
	}
}
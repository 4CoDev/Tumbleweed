using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh.PrimitiveType;

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
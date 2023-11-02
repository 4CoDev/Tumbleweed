using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh.PrimitiveType;

public sealed class Triangles : Envelope<Godot.Mesh.PrimitiveType>
{
	public Triangles() : base
	(
		new One<Godot.Mesh.PrimitiveType>(
			Godot.Mesh.PrimitiveType.Triangles)
	)
	{
	}
}
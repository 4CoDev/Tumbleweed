using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Graphical.ArrayMesh.From.Mesh;

public sealed class One : Envelope<Godot.ArrayMesh>
{
	public One(Any<Godot.Mesh> mesh) : base
	(
		new global::Tumbleweed.Object.Unpacked<Godot.ArrayMesh>(mesh)
	)
	{
	}
}